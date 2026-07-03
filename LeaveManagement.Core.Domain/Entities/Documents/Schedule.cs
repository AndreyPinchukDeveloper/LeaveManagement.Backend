using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums.Documents;

namespace LeaveManagement.Core.Domain.Entities.Documents;

public sealed class Schedule : AggregateRoot
{
    public ScheduleState State { get; set; }
    public int Year { get; private set; }
    public Guid EmployeeId { get; set; }
}