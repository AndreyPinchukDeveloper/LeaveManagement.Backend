using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums.Documents;

namespace LeaveManagement.Core.Domain.Entities.Documents;

public sealed class Order : DomainEntity
{
    public OrderState State { get; set; }
}
