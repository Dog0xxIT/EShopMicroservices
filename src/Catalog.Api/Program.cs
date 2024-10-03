using Catalog.Api.Services.CloudinaryService;

var builder = WebApplication.CreateBuilder(args);

//builder.AddRabbitMqEventBus("localhost")
//        .AddSubscription<Event1, EventHandler1>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<CatalogContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddTransient<ICloudinaryService, CloudinaryService>();

builder.Services.AddTransient<ICatalogService, CatalogService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy
            .WithOrigins("https://localhost:7212")
            .WithOrigins("https://localhost:7258")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials(); // Allow to send cookies
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();