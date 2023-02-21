using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientDepartment : Entity, IAuditableEntity
    {
        public int ClientDepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? SysCode { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; } = null!;
    }
}
