namespace LeaveManagement.Core.Domain.Interfaces;

public interface IDomainEvent
{
    DateTime OccuredOnUtc { get; }
    string SourceDomainEntityType { get; }
    Guid SourceDomainEntityId { get; }

}
