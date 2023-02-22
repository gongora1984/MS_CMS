namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientAssignmentTaskRule : Entity, IAuditableEntity
    {
        public bool Active { get; set; }
        public string? EffectiveStartDate { get; set; }
        public string? EffectiveEndDate { get; set; }
        public bool? OnlyIfMet { get; set; }
        public bool? NotIfMet { get; set; }
        public string? State { get; set; }
        public string? County { get; set; }
        public string? Client { get; set; }
        public string? ReplevinType { get; set; }
        public string? Bkstate { get; set; }
        public string? Bkdistrict { get; set; }
        public string? Bkchapter { get; set; }
        public string? RuleType { get; set; }
        public int ClientAssignmentTaskCheckListId { get; set; }

        public virtual ClientAssignmentTaskCheckList ClientAssignmentTaskCheckList { get; set; } = null!;
    }
}
