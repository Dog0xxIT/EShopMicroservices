using EventPublisherService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<PublisherWorker>();

var host = builder.Build();
host.Run();
