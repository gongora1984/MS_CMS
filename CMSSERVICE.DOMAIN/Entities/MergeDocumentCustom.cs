using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class MergeDocumentCustom : Entity, IAuditableEntity
    {
        public int MergeDocumentCustomId { get; set; }
        public int? ClientId { get; set; }
        public int? LawPracticeId { get; set; }
        public int? CountyId { get; set; }
        public int? DistrictId { get; set; }
        public string? TemplateLocation { get; set; }
        public string? CodePageLocation { get; set; }
        public string? BlankDataValue { get; set; }
        public string? BitYesValue { get; set; }
        public string? BitNoValue { get; set; }
        public int MergeDocumentId { get; set; }

        public virtual MergeDocument MergeDocument { get; set; } = null!;
    }
}
