using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class MergeDocumentToken : Entity, IAuditableEntity
    {
        public int MergeDocumentTokenId { get; set; }
        public string? MergeToken { get; set; }
        public string? MergeDocumentPath { get; set; }
        public string? SelectValueSql { get; set; }
        public bool? IsSql { get; set; }
        public bool? IsSqlFunction { get; set; }
    }
}
