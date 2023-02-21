using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LogonDetailsAssignmentPoolTask : Entity, IAuditableEntity
    {
        public int LogonDetailsAssignmentPoolTasksId { get; set; }
        public int LogonDetailsAssignmentPoolId { get; set; }
        public int ClientAssignmentTaskId { get; set; }

        public virtual ClientAssignmentTask ClientAssignmentTask { get; set; } = null!;
        public virtual LogonDetailsAssignmentPool LogonDetailsAssignmentPool { get; set; } = null!;
    }
}
