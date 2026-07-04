namespace LeaveManagement.Core.Domain.Interfaces.Repositories.Persistance.Base;

public interface IDomainEntityBase
{
    Guid Id { get; }
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    void AddDomainEvent(IDomainEvent domainEvent);
    void ClearDomainEvents();
}
