namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleFileAssign : Entity, IAuditableEntity
    {
        public string? AssignFrom { get; set; }
        public string? AssignTo { get; set; }
        public DateTime? RecordedDate { get; set; }
        public string? InstrumentNum { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
    }
}
