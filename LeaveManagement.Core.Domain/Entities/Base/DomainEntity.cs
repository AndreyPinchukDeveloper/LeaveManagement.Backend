using LeaveManagement.Core.Domain.Interfaces;
using LeaveManagement.Core.Domain.Interfaces.Repositories.Persistance.Base;

namespace LeaveManagement.Core.Domain.Entities.Base;

public abstract class DomainEntity : IDomainEntityBase
{
    public Guid Id { get; private set; }
    private readonly List<IDomainEvent> _domainEvents = [];
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public DomainEntity(Guid id)
    {
        Id = id;
    }

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        ArgumentNullException.ThrowIfNull(domainEvent, nameof(domainEvent));
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
