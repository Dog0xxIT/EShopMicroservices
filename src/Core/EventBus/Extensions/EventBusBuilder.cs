using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBus.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace EventBus.Extensions
{
    internal class EventBusBuilder : IEventBusBuilder
    {
        public IServiceCollection Services { get; }

        public EventBusBuilder(IServiceCollection services)
        {
            Services = services;
        }
    }
}
