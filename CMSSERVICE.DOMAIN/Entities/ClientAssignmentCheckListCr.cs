namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentCheckListCr : Entity, IAuditableEntity
    {
        public int ClientAssignmentTaskCheckListCrid { get; set; }
        public int ClientAssignmentTaskCheckListId { get; set; }
        public string Value { get; set; } = null!;

        public virtual ClientAssignmentTaskCheckList ClientAssignmentTaskCheckList { get; set; } = null!;
        public virtual ClientAssignmentTaskCheckListCr ClientAssignmentTaskCheckListCr { get; set; } = null!;
    }
}
