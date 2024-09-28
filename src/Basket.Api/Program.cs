using System.Security.Principal;
using Basket.Api.Services.CatalogService;
using Basket.Api.Services.IdentityService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BasketContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddHttpClient("CatalogClient", httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7038");
    });

builder.Services
    .AddHttpClient("IdentityClient", httpClient =>
    {
        httpClient.BaseAddress = new Uri("https://localhost:7038");
    });

builder.Services.AddTransient<ICatalogService, CatalogService>();

builder.Services.AddTransient<IIdentityService, IdentityService>();

builder.Services.AddControllers();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
