using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace EventBus.RabbitMQ
{
    public class RabbitMqEventBus : IEventBus
    {
        private readonly ILogger<RabbitMqEventBus> _logger;
        private readonly IOptions<RabbitMqEventBusOptions> _rabbitMqEventBusOptions;
        private readonly IOptions<SubscriptionInfo> _subscriptionOptions;
        private const string ExchangeName = "eshop_event_bus";
        private readonly IConnection _rabbitMqConnection;

        public RabbitMqEventBus(ILogger<RabbitMqEventBus> logger,
            IOptions<RabbitMqEventBusOptions> rabbitMqEventBusOptions,
            IConnection rabbitMqConnection,
            IOptions<SubscriptionInfo> subscriptionOptions)
        {
            _logger = logger;
            _rabbitMqEventBusOptions = rabbitMqEventBusOptions;
            _rabbitMqConnection = rabbitMqConnection;
            _subscriptionOptions = subscriptionOptions;
        }

        public async Task PublishAsync(IntegrationEvent integrationEvent)
        {
            var channel = _rabbitMqConnection.CreateModel();

            channel.ExchangeDeclare(exchange: ExchangeName, type: ExchangeType.Direct);

            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(integrationEvent));

            channel.BasicPublish(
                exchange: ExchangeName,
                routingKey: integrationEvent.GetType().Name,
                basicProperties: null,
                body: body);
        }
    }
}
