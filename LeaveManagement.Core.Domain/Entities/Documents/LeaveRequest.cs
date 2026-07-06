using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums;
using LeaveManagement.Core.Domain.Entities.Enums.Documents;

namespace LeaveManagement.Core.Domain.Entities.Documents;

public sealed class LeaveRequest : AggregateRoot
{
    public string RequestNumber { get; private set; }
    public Guid EmployeeId { get; private set; }
    public LeaveType LeaveType { get; private set; }
    public LeaveRequestStatus Status { get; private set; }

    // Leave Period
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }

    /// <summary>
    /// // For half-day leave
    /// </summary>
    public bool StartHalfDay { get; private set; } 
    public bool EndHalfDay { get; private set; }

    /// <summary>
    /// // Excluding public holidays
    /// </summary>
    public decimal TotalDays { get; private set; } 

    // Parental Leave Specific
    public DateTime? ExpectedBirthDate { get; private set; }
    public DateTime? PartnerLeaveStartDate { get; private set; }
    public bool IsPrimaryCarer { get; private set; }

    // Audit
    public DateTime CreatedAt { get; private set; }
    public DateTime? ModifiedAt { get; private set; }
    public string ModifiedBy { get; private set; }

    private readonly List<MedicalCertificate> _medicalCertificates;
    public IReadOnlyList<MedicalCertificate> MedicalCertificate => _medicalCertificates.AsReadOnly();

    public LeaveRequest(Guid id, string requestNumber, Guid employeeId, LeaveType leaveType, LeaveRequestStatus status, DateTime startDate, DateTime endDate, bool startHalfDay, bool endHalfDay, decimal totalDays, DateTime? expectedBirthDate, DateTime? partnerLeaveStartDate, bool isPrimaryCarer, DateTime createdAt, DateTime? modifiedAt, string modifiedBy,
        IEnumerable<MedicalCertificate> medicalCertificates) : base(id)
    {
        RequestNumber = requestNumber;
        EmployeeId = employeeId;
        LeaveType = leaveType;
        Status = status;
        StartDate = startDate;
        EndDate = endDate;
        StartHalfDay = startHalfDay;
        EndHalfDay = endHalfDay;
        TotalDays = totalDays;
        ExpectedBirthDate = expectedBirthDate;
        PartnerLeaveStartDate = partnerLeaveStartDate;
        IsPrimaryCarer = isPrimaryCarer;
        CreatedAt = createdAt;
        ModifiedAt = modifiedAt;
        ModifiedBy = modifiedBy;

        _medicalCertificates = medicalCertificates.ToList();
    }
}
