using LeaveManagement.Core.Domain.Entities.Base;

namespace LeaveManagement.Core.Domain.Entities.Documents;

public sealed class Schedule : AggregateRoot
{
    public int Year { get; private set; }
}
