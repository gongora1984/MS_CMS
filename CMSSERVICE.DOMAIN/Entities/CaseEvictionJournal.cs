namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseEvictionJournal : Entity, IAuditableEntity
    {
        public string? OtherKey { get; set; }
        public DateTime JournalDate { get; set; }
        public string Action { get; set; } = null!;
        public int CaseEvictionId { get; set; }
        public int LoginDetailId { get; set; }

        public virtual CaseEviction CaseEviction { get; set; } = null!;
        public virtual LoginDetail LoginDetail { get; set; } = null!;
    }
}
