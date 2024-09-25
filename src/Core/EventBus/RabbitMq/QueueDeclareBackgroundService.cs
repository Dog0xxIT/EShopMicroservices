using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client.Events;
using EventBus.RabbitMQ;
using EventBus.Abstractions;
using Microsoft.Extensions.Options;
using System.Collections;

namespace EventBus.RabbitMq
{
    internal class QueueDeclareBackgroundService : BackgroundService
    {
        private readonly IOptions<RabbitMqEventBusOptions> _rabbitMqEventBusOptions;
        private readonly IOptions<SubscriptionInfo> _subscriptionOptions;
        private readonly ILogger<QueueDeclareBackgroundService> _logger;
        private readonly IConnection _rabbitMqConnection;
        private const string ExchangeName = "eshop_event_bus";

        public QueueDeclareBackgroundService(IOptions<RabbitMqEventBusOptions> rabbitMqEventBusOptions, IOptions<SubscriptionInfo> subscriptionOptions, ILogger<QueueDeclareBackgroundService> logger, IConnection rabbitMqConnection)
        {
            _rabbitMqEventBusOptions = rabbitMqEventBusOptions;
            _subscriptionOptions = subscriptionOptions;
            _logger = logger;
            _rabbitMqConnection = rabbitMqConnection;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var channel = _rabbitMqConnection.CreateModel();
            channel.ExchangeDeclare(exchange: ExchangeName, type: ExchangeType.Direct);

            // declare a server-named queue
            var queueName = _rabbitMqEventBusOptions.Value.SubscriptionClientName;

            channel.QueueDeclare(
                queue: queueName,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            foreach (var eventName in _subscriptionOptions.Value.Events)
            {
                channel.QueueBind(
                    queue: queueName,
                    exchange: ExchangeName,
                    routingKey: eventName.Name);
            }

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (model, ea) =>
            {
                byte[] body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
            };

            channel.BasicConsume(queue: queueName,
                autoAck: true,
                consumer: consumer);

            return Task.CompletedTask;
        }
    }
}
