using LeaveManagement.Core.Domain.Entities.Base;

namespace LeaveManagement.Core.Domain.Organization;

public sealed class Department : DomainEntity
{
    public string Name { get; private set; }
    public string Code { get; private set; }
    public Guid? ParentDepartmentId { get; private set; }
    public bool IsActive { get; private set; }

    private Department(Guid id, string name, string code, Guid? parentDepartmentId = null) : base(id)
    {
        Name = name;
        Code = code;
        ParentDepartmentId = parentDepartmentId;
        IsActive = true;
    }

    public void Update(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public void Deactivate() => IsActive = false;
    public void Activate() => IsActive = true;
}
