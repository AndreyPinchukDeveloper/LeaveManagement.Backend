using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums;

namespace LeaveManagement.Core.Domain.Entities;

public sealed class Organization : AggregateRoot
{
    public string ShortName { get; private set; }
    public string FullName { get; private set; }
    public CountryCode CountryCode { get; private set; }
}
