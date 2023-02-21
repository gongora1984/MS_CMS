using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleModParagraph : Entity, IAuditableEntity
    {
        public int CaseTitleModParagraphId { get; set; }
        public DateTime? RecordedDate { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public string? Intrument { get; set; }
        public bool UnrecordedMod { get; set; }
        public DateTime? UnRecordedDate { get; set; }
        public decimal? ModificationAmount { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
    }
}
