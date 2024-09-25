using EventStoreEF.Manage;
using EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EventPublisherService
{
    public class PublisherWorker : BackgroundService
    {
        private readonly ILogger<PublisherWorker> _logger;
        private readonly IEvenLogManage _evenLogManage;
        private readonly IEventBus _eventBus;
        private const int MaxRetryAttempts = 3;
        private readonly TimeSpan _retryDelay = TimeSpan.FromSeconds(5);

        public PublisherWorker(ILogger<PublisherWorker> logger, IEvenLogManage evenLogManage, IEventBus eventBus)
        {
            _logger = logger;
            _evenLogManage = evenLogManage;
            _eventBus = eventBus;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var eventList = await _evenLogManage.GetAllEventNotPublished(Guid.NewGuid());

                foreach (var eventLog in eventList)
                {
                    var e = new IntegrationEvent();

                    // Retry mechanism
                    var retryCount = 0;
                    var published = false;

                    while (retryCount < MaxRetryAttempts && !published)
                    {
                        try
                        {
                            await _eventBus.PublishAsync(e);
                            await _evenLogManage.MarkEventAsPublishedAsync(eventLog.EventId);
                            published = true;
                        }
                        catch (Exception ex)
                        {
                            retryCount++;
                            _logger.LogError(ex, "Error publishing event with ID {EventId}, attempt {RetryAttempt} of {MaxRetryAttempts}", eventLog.EventId, retryCount, MaxRetryAttempts);

                            if (retryCount < MaxRetryAttempts)
                            {
                                // Wait before retrying
                                await Task.Delay(_retryDelay, stoppingToken);
                            }
                            else
                            {
                                _logger.LogError("Max retry attempts reached for event {EventId}. Event will not be retried.", eventLog.EventId);
                            }
                        }
                    }
                }
            }
        }
    }
}
