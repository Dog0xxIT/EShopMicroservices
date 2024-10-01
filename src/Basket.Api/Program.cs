using System.Text;
using Basket.Api.Configurations;
using Basket.Api.Services.CatalogService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BasketContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddHttpClient("CatalogClient", httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7038");
    });

builder.Services.AddTransient<ICatalogService, CatalogService>();

builder.Services.AddControllers();

builder.Services
    .AddAuthentication("Bearer")
    .AddJwtBearer(options =>
    {
        var jwtConfig = new JwtConfig();
        builder.Configuration.GetSection(JwtConfig.SectionName).Bind(jwtConfig);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = jwtConfig.Issuer,
            ValidAudience = jwtConfig.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.SecretKey)),
        };
        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                context.Token = context.Request.Cookies["access-token"]; // Get token from cookie
                return Task.CompletedTask;
            },
        };
    });


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy
            .WithOrigins("https://localhost:7258")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials(); // Allow to send cookies
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.MapControllers();

app.UseAuthentication();

app.UseAuthorization();

app.Run();
