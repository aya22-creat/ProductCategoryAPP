using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategoryApp.Domain.Common
{
    public abstract class BaseEntity
    {
        private readonly List<IDomainEvent> _domainEvents = new(); // not edit ,encapsulated

        public Guid Id { get; protected set; } = Guid.NewGuid(); // Unique identifier for the entity
  
        // Timestamp for when the entity was last updated application and infrastructure can see this
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly(); // Expose domain events as read-only

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}