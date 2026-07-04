using LeaveManagement.Core.Domain.Entities.Base;

namespace LeaveManagement.Core.Domain.Entities;

public sealed class Employee : AggregateRoot
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string MiddleName { get; private set; }
    public string AccountName { get; private set; }
    public string? Email { get; private set; }


    public bool IsAdmin { get; private set; }
    public bool IsApprover { get; private set; }
    public bool IsManager { get; private set; }

    public Employee(string firstName, string lastName, string middleName, string accountName, string? email, bool isAdmin, bool isApprover, bool isManager)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        AccountName = accountName;
        Email = email;
        IsAdmin = isAdmin;
        IsApprover = isApprover;
        IsManager = isManager;
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

    public Guid OrganizationId { get; private set; }//only reference to aggregate root
}
