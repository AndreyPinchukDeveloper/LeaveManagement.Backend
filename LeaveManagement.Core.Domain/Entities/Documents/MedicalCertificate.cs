using LeaveManagement.Core.Domain.Entities.Base;
using LeaveManagement.Core.Domain.Entities.Enums;

namespace LeaveManagement.Core.Domain.Entities.Documents;

public sealed class MedicalCertificate : DomainEntity
{
    public MedicalCertificateType CertificateType { get; set; }

    // Certificate Details
    public string DoctorName { get; private set; }
    public string ProviderNumber { get; private set; }
    public string PracticeName { get; private set; }
    public string PracticeAddress { get; private set; }

    // Leave Period Covered
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public DateTime? ReturnToWorkDate { get; private set; }

    // Work Capacity
    public bool FitForWork { get; private set; }
    public bool SuitableForModifiedDuties { get; private set; }
    public string Restrictions { get; private set; }

    public MedicalCertificate(Guid id, MedicalCertificateType certificateType, string doctorName, string providerNumber, string practiceName, string practiceAddress, DateTime startDate, DateTime endDate, DateTime? returnToWorkDate, bool fitForWork, bool suitableForModifiedDuties, string restrictions) : base(id)
    {
        CertificateType = certificateType;
        DoctorName = doctorName;
        ProviderNumber = providerNumber;
        PracticeName = practiceName;
        PracticeAddress = practiceAddress;
        StartDate = startDate;
        EndDate = endDate;
        ReturnToWorkDate = returnToWorkDate;
        FitForWork = fitForWork;
        SuitableForModifiedDuties = suitableForModifiedDuties;
        Restrictions = restrictions;
    }
}
