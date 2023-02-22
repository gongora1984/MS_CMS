namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentTaskCheckListVr : Entity, IAuditableEntity
    {
        public string CompareValue { get; set; } = null!;
        public string? StartAssigmnmentOnMatch { get; set; }
        public string? RunCommandOnMatch { get; set; }
        public string? StartAssigmnmentOnNoMatch { get; set; }
        public string? RunCommandOnNoMatch { get; set; }
        public int ClientAssignmentTaskCheckListId { get; set; }

        public virtual ClientAssignmentTaskCheckList ClientAssignmentTaskCheckList { get; set; } = null!;
    }
}
