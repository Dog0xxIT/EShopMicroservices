namespace Catalog.Api.IntegrationEvents.PublishEvents
{
    public class ChangePriceEventHanler : IEventHandler
    {
        private readonly IEventBus _eventBus;

        public ChangePriceEventHanler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task Handle()
        {
            await _eventBus.PublishAsync(new ChangePriceEvent());
        }
    }
}
