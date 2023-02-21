using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentCheckListVr : Entity, IAuditableEntity
    {
        public int ClientAssignmentCheckListVrid { get; set; }
        public string Value { get; set; } = null!;
        public string? ValueDisplay { get; set; }
        public int ClientAssignmentTaskCheckListId { get; set; }
        public int ClientAssignmentId { get; set; }

        public virtual ClientAssignment ClientAssignment { get; set; } = null!;
        public virtual ClientAssignmentTaskCheckList ClientAssignmentTaskCheckList { get; set; } = null!;
    }
}
