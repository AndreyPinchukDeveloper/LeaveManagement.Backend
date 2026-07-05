using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums;

namespace LeaveManagement.Core.Domain.Entities;

public sealed class Employee : AggregateRoot
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string MiddleName { get; private set; }
    public string AccountName { get; private set; }
    public string? Email { get; private set; }
    public string? Phone { get; private set; }

    // Employment Details
    public DateTime CommencementDate { get; private set; }
    public DateTime? TerminationDate { get; private set; }
    public EmploymentType EmploymentType { get; private set; }
    public decimal WeeklyHours { get; private set; } // 38 for full-time
    public int WorkingDaysPerWeek { get; private set; } // Usually 5

    // Award/Agreement Details
    public string AwardCode { get; private set; }
    public string AwardName { get; private set; }
    public bool IsShiftWorker { get; private set; }
    public bool EligibleForLeaveLoading { get; private set; }
    public decimal LeaveLoadingPercentage { get; private set; }

    // Leave Accrual Configuration
    public decimal AnnualLeaveWeeksPerYear { get; private set; }
    public bool ProRataLeave { get; private set; } = true;

    // State for Long Service Leave
    public AustralianState State { get; private set; }

    public bool IsAdmin { get; private set; }
    public bool IsApprover { get; private set; }
    public bool IsManager { get; private set; }

    public Guid OrganizationId { get; private set; }
    public Guid DepartmentId { get; private set; }

    public Employee(
        Guid id,
        string firstName,
        string lastName,
        string middleName,
        string accountName,
        string? email,
        bool isAdmin,
        bool isApprover,
        bool isManager,
        Guid organizationId,
        Guid departmentId,
        string? phone,
        DateTime commencementDate,
        DateTime? terminationDate,
        EmploymentType employmentType,
        decimal weeklyHours,
        int workingDaysPerWeek,
        string awardCode,
        string awardName,
        bool isShiftWorker,
        bool eligibleForLeaveLoading,
        decimal leaveLoadingPercentage,
        decimal annualLeaveWeeksPerYear,
        bool proRataLeave,
        AustralianState state) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        AccountName = accountName;
        Email = email;
        IsAdmin = isAdmin;
        IsApprover = isApprover;
        IsManager = isManager;
        OrganizationId = organizationId;
        DepartmentId = departmentId;
        Phone = phone;
        CommencementDate = commencementDate;
        TerminationDate = terminationDate;
        EmploymentType = employmentType;
        WeeklyHours = weeklyHours;
        WorkingDaysPerWeek = workingDaysPerWeek;
        AwardCode = awardCode;
        AwardName = awardName;
        IsShiftWorker = isShiftWorker;
        EligibleForLeaveLoading = eligibleForLeaveLoading;
        LeaveLoadingPercentage = leaveLoadingPercentage;
        AnnualLeaveWeeksPerYear = annualLeaveWeeksPerYear;
        ProRataLeave = proRataLeave;
        State = state;
    }
    public string FullName => $"{LastName} {FirstName} {MiddleName}";

    public string ShortName
    {
        get
        {
            var result = LastName.Trim();
            if (!string.IsNullOrWhiteSpace(FirstName))
                result += $" {FirstName.Trim()[0]}.";

            if (!string.IsNullOrWhiteSpace(MiddleName))
                result += $" {MiddleName.Trim()[0]}.";
            return result;
        }
    }
}
