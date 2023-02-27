namespace CMSSERVICE.DOMAIN.Entities;

public partial class AppRoleLoginDetail : Entity, IAuditableEntity
{
    public int AppRoleId { get; set; }
    public int LoginDetailId { get; set; }

    public virtual AppRole AppRole { get; set; } = null!;
    public virtual LoginDetail LoginDetail { get; set; } = null!;
}
