using Catalog.Api.Infrastructure;
using Catalog.Api.Service.CloudinaryService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICloudinaryService, CloudinaryService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.
    AddDbContext<CatalogContext>(options => options.UseSqlServer(connectionString), contextLifetime: ServiceLifetime.Transient);

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

