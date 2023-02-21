using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleUnderWriter : Entity, IAuditableEntity
    {
        public CaseTitleUnderWriter()
        {
            CaseTitles = new HashSet<CaseTitle>();
        }

        public int CaseTitleUnderWriterId { get; set; }
        public string UnderWriterName { get; set; } = null!;
        public string UnderWriterSendVia { get; set; } = null!;
        public string? UnderWriterAttentionTo { get; set; }
        public string UnderWriterAddress1 { get; set; } = null!;
        public string? UnderWriterAddress2 { get; set; }
        public string UnderWriterCity { get; set; } = null!;
        public string UnderWriterState { get; set; } = null!;
        public string UnderWriterZip { get; set; } = null!;
        public string? SendEmail { get; set; }
        public bool SendMail { get; set; }
        public bool SendUps { get; set; }

        public virtual ICollection<CaseTitle> CaseTitles { get; set; }
    }
}
