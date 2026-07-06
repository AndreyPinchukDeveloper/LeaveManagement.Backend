using LeaveManagement.Core.Domain.Entities.Base;

namespace LeaveManagement.Core.Domain.Entities.Documents;

public sealed class LeavePolicy : AggregateRoot
{
    public LeavePolicy(Guid id) : base(id)
    {
    }
}
