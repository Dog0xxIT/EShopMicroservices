using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBus.Abstractions;
using EventStoreEF.Models;

namespace EventStoreEF.Manage
{
    public interface IEvenLogManage
    {
        Task<IEnumerable<EventLog>> GetAllEventNotPublished(Guid transactionId);
        Task AddEventLog(IntegrationEvent integrationEvent, Guid transactionId);
        Task MarkEventAsPublishedAsync(Guid eventId);
    }
}
