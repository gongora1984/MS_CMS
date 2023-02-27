namespace CMSSERVICE.DOMAIN.Entities;

public partial class AppRole : Entity, IAuditableEntity
{
    ////public static readonly AppRole Admin = new("Admin");
    public AppRole()
    {
        AppRoleLoginDetails = new HashSet<AppRoleLoginDetail>();
        AppRolePermissions = new HashSet<AppRolePermission>();
    }

    ////public AppRole(string roleName)
    ////{
    ////    AppRoleLoginDetails = new HashSet<AppRoleLoginDetail>();
    ////    AppRolePermissions = new HashSet<AppRolePermission>();
    ////    Name = roleName;
    ////}

    public string Name { get; set; } = null!;

    public virtual ICollection<AppRoleLoginDetail> AppRoleLoginDetails { get; set; }
    public virtual ICollection<AppRolePermission> AppRolePermissions { get; set; }
}
