using LeaveManagement.Core.Domain.Entities.Base;

namespace LeaveManagement.Core.Domain.Entities.Documents;

/// <summary>
/// Company-level leave policy configuration
/// Implements Fair Work Act minimums or above-award entitlements
/// </summary>
public sealed class LeavePolicy : AggregateRoot
{
    public string Name { get; private set; }  // "Annual Leave Policy 2026"
    public string Version { get; private set; }  // "3.2"
    public string PolicyNumber { get; private set; }  // "HR-POL-001"
    public DateTime EffectiveDate { get; private set; }
    public DateTime? EndDate { get; private set; }  // For version control
    public bool IsActive { get; private set; }

    // Audit
    public string CreatedBy { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public Guid LastModifiedBy { get; private set; }
    public DateTime? LastModifiedDate { get; private set; }

    public LeavePolicy(Guid id, string name, string version, string policyNumber, DateTime effectiveDate, DateTime? endDate, bool isActive, string createdBy, DateTime createdDate, Guid lastModifiedBy, DateTime? lastModifiedDate) : base(id)
    {
        Name = name;
        Version = version;
        PolicyNumber = policyNumber;
        EffectiveDate = effectiveDate;
        EndDate = endDate;
        IsActive = isActive;
        CreatedBy = createdBy;
        CreatedDate = createdDate;
        LastModifiedBy = lastModifiedBy;
        LastModifiedDate = lastModifiedDate;
    }
}
