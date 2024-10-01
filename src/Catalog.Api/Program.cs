using Catalog.Api.Infrastructure;
using Catalog.Api.Service.CloudinaryService;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client.Core.DependencyInjection;
using EventBus.Extensions;

var builder = WebApplication.CreateBuilder(args);

//builder.AddRabbitMqEventBus("localhost")
//        .AddSubscription<Event1, EventHandler1>();

builder.Services.AddTransient<ICloudinaryService, CloudinaryService>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.
    AddDbContext<CatalogContext>(
        options => options.UseSqlServer(connectionString),
        contextLifetime: ServiceLifetime.Transient);

builder.Services.AddControllers();
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