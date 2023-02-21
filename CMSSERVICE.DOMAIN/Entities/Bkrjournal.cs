namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrJournal : Entity, IAuditableEntity
    {
        public string? OtherKey { get; set; }
        public DateTime JournalDate { get; set; }
        public string Action { get; set; } = null!;
        public int CaseBkrId { get; set; }
        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
