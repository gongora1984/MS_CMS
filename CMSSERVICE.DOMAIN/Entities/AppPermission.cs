namespace CMSSERVICE.DOMAIN.Entities;

public partial class AppPermission : Entity, IAuditableEntity
{
    public AppPermission()
    {
        AppRolePermissions = new HashSet<AppRolePermission>();
    }

    public string Name { get; set; } = null!;

    public virtual ICollection<AppRolePermission> AppRolePermissions { get; set; }
}
