namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentJournal : Entity, IAuditableEntity
    {
        public long SecondCounter { get; set; }
        public int ClientAssignmentId { get; set; }
        public int LoginDetailId { get; set; }

        public virtual ClientAssignment ClientAssignment { get; set; } = null!;
        public virtual LoginDetail LoginDetail { get; set; } = null!;
    }
}
