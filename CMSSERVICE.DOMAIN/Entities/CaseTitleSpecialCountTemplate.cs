using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleSpecialCountTemplate : Entity, IAuditableEntity
    {
        public CaseTitleSpecialCountTemplate()
        {
            CaseTitleSpecialCounts = new HashSet<CaseTitleSpecialCount>();
        }

        public int CaseTitleSpecialCountTemplateId { get; set; }
        public string TitleSpecialCountTemplateName { get; set; } = null!;
        public string? TitleSpecialCountTemplateTitle { get; set; }
        public string TitleSpecialCountTemplateText { get; set; } = null!;
        public string? TitleSctmergeParagraphMsj { get; set; }
        public string? TitleSctmergeParagraphFj { get; set; }
        public string? Other { get; set; }
        public string? StateId { get; set; }
        public int? CountTypeLid { get; set; }

        public virtual ListItem? CountTypeL { get; set; }
        public virtual ICollection<CaseTitleSpecialCount> CaseTitleSpecialCounts { get; set; }
    }
}
