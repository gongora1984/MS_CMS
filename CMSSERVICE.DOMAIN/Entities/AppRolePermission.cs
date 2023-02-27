namespace CMSSERVICE.DOMAIN.Entities;

public class AppRolePermission : Entity, IAuditableEntity
{
    public int AppPermissionId { get; set; }
    public int AppRoleId { get; set; }

    public virtual AppPermission AppPermission { get; set; } = null!;
    public virtual AppRole AppRole { get; set; } = null!;
}
