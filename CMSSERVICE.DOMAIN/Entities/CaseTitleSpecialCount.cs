namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleSpecialCount : Entity, IAuditableEntity
    {
        public string TitleSpecialCountText { get; set; } = null!;
        public string? TitleSpecialCountTitle { get; set; }
        public string? ByVirtueOf { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public DateTime? RecordedDate { get; set; }
        public string? Grantors { get; set; }
        public string? Grantees { get; set; }
        public int CaseTitleId { get; set; }
        public int CaseTitleSpecialCountTemplateId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
        public virtual CaseTitleSpecialCountTemplate CaseTitleSpecialCountTemplate { get; set; } = null!;
    }
}
