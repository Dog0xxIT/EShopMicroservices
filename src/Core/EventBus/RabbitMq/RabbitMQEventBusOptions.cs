using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.RabbitMQ
{
    public class RabbitMqEventBusOptions
    {
        public static readonly string SectionName = "EventBus";
        public string SubscriptionClientName { get; set; }
    }
}
