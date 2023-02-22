namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class MergeDocumentToken : Entity, IAuditableEntity
    {
        public string? MergeToken { get; set; }
        public string? MergeDocumentPath { get; set; }
        public string? SelectValueSql { get; set; }
        public bool? IsSql { get; set; }
        public bool? IsSqlFunction { get; set; }
    }
}
