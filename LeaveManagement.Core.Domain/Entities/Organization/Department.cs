using LeaveManagement.Core.Domain.Entities.Base;

namespace LeaveManagement.Core.Domain.Entities.Organization;

/// <summary>
/// We use AggregateRoot because we work with very large organizations
/// </summary>
public sealed class Department : AggregateRoot
{
    public Guid OrganizationId { get; private set; }
    public string Name { get; private set; }
    public string Code { get; private set; }
    public Guid ParentDepartmentId { get; private set; }
    public bool IsActive { get; private set; }
    private readonly List<Guid> _subDepartmentIds = new();
    public IReadOnlyCollection<Guid> SubDepartmentIds => _subDepartmentIds.AsReadOnly();

    public Department(Guid id, Guid organizationId, string name, string code, Guid parentDepartmentId = null) : base(id)
    {
        OrganizationId = organizationId;
        Name = name;
        Code = code;
        ParentDepartmentId = parentDepartmentId;
        IsActive = true;
    }

    public void Deactivate() => IsActive = false;
    public void Activate() => IsActive = true;
}
