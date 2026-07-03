using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums;
using LeaveManagement.Core.Domain.Entities.Enums.Documents;

namespace LeaveManagement.Core.Domain.Entities.Documents;

public sealed class Request : DomainEntity
{
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public RequestState State { get; set; }
    public VacationType VacationType { get; set; }
}
