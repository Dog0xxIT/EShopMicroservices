using System;
using System.Collections.Generic;
using MediatR;

namespace Ordering.Domain.Common
{
    public abstract class BaseEntity
    {
        public string Id { get; private set; } // = Guid.NewGuid().ToString();

        // TimeStamp
        public double Created { get; private set; } = DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;

        // TimeStamp
        public double LastModified { get; private set; }

        public bool IsDeleted { get; set; }

        protected List<INotification> _domainEvents { get; } = new();

        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents;

        public void SetTimeLastModified()
        {
            LastModified = DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
        }

        protected BaseEntity()
        {
        }

        protected BaseEntity(string id)
        {
            Id = string.IsNullOrWhiteSpace(id) ? throw new ArgumentNullException(nameof(id)) : id;
        }

        public void ClearDomainEvents() => _domainEvents.Clear();
    }
}
