namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleAssignmentItem : Entity, IAuditableEntity
    {
        public string TitleAssignmentDescription { get; set; } = null!;
        public decimal? TitleAssignmentCost { get; set; }
        public decimal? TitleAssignmentFee { get; set; }
        public int? DefaultDaysToComplete { get; set; }
        public string? StateId { get; set; }
        public int CaseTitleAssignmentId { get; set; }

        public virtual CaseTitleAssignment CaseTitleAssignment { get; set; } = null!;
    }
}
