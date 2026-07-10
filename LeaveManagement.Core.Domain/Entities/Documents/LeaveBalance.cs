using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums;

namespace LeaveManagement.Core.Domain.Entities.Documents;

/// <summary>
/// Current balance of a specific leave type for an employee
/// </summary>
public class LeaveBalance : DomainEntity
{
    public Guid EmployeeId { get; private set; }
    public LeaveType LeaveType { get; private set; }

    /// <summary>
    /// Current accrued hours/days
    /// </summary>
    public decimal CurrentBalance { get; private set; }

    /// <summary>
    /// Leave accrual rate per pay period 
    /// (e.g., 2.923 hours per week for annual leave)
    /// </summary>
    public decimal AccrualRate { get; private set; }

    /// <summary>
    /// Date of last accrual calculation
    /// </summary>
    public DateTime LastAccrualDate { get; private set; }

    /// <summary>
    /// Total taken in current year (for reporting)
    /// </summary>
    public decimal TakenThisYear { get; private set; }

    /// <summary>
    /// Some awards allow leave to accrue indefinitely, others cap it
    /// </summary>
    public decimal? MaximumBalanceCap { get; private set; }

    /// <summary>
    /// For long service leave - date when employee qualifies
    /// </summary>
    public DateTime? LongServiceLeaveQualificationDate { get; private set; }

    // Audit
    public string CreatedBy { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public Guid LastModifiedBy { get; private set; }
    public DateTime? LastModifiedDate { get; private set; }

    public LeaveBalance(Guid id, Guid employeeId, LeaveType leaveType, decimal currentBalance, decimal accrualRate, DateTime lastAccrualDate, decimal takenThisYear, 
        decimal? maximumBalanceCap, DateTime? longServiceLeaveQualificationDate, string createdBy, DateTime createdDate, Guid lastModifiedBy, DateTime? lastModifiedDate) : base(id)
    {
        EmployeeId = employeeId;
        LeaveType = leaveType;
        CurrentBalance = currentBalance;
        AccrualRate = accrualRate;
        LastAccrualDate = lastAccrualDate;
        TakenThisYear = takenThisYear;
        MaximumBalanceCap = maximumBalanceCap;
        LongServiceLeaveQualificationDate = longServiceLeaveQualificationDate;
        CreatedBy = createdBy;
        CreatedDate = createdDate;
        LastModifiedBy = lastModifiedBy;
        LastModifiedDate = lastModifiedDate;
    }

}
