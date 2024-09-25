using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using EventBus.Abstractions;
using EventBus.RabbitMq;
using EventBus.RabbitMQ;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;

namespace EventBus.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IEventBusBuilder AddRabbitMqEventBus(this IHostApplicationBuilder builder, string connectionName)
        {

            builder.Services.AddTransient<IConnection>((serviceprovider) =>
            {
                {
                    var connFactory = new ConnectionFactory
                    {
                        HostName = connectionName,
                    };
                    return connFactory.CreateConnection();
                }
            });

            builder.Services.Configure<RabbitMqEventBusOptions>(options =>
                builder.Configuration
                    .GetSection(RabbitMqEventBusOptions.SectionName)
                    .Bind(options));

            builder.Services.AddSingleton<IEventBus, RabbitMqEventBus>();
            builder.Services.AddHostedService<QueueDeclareBackgroundService>();
            return new EventBusBuilder(builder.Services);
        }

        public static IServiceCollection AddSubscription<T1, T2>(this IEventBusBuilder builder)
            where T1 : IntegrationEvent
            where T2 : class, IEventHandler
        {

            builder.Services.AddTransient<T2>();

            builder.Services.Configure<SubscriptionInfo>(o =>
            {
                o.Events.Add(typeof(T1));
            });

            return builder.Services;
        }
    }
}
