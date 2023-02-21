using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class MergeField : Entity, IAuditableEntity
    {
        public int MergeFieldId { get; set; }
        public string TableName { get; set; } = null!;
        public string MergeFieldName { get; set; } = null!;
        public string MergeToken { get; set; } = null!;
        public string MissingValueQuestion { get; set; } = null!;
        public string? UpdateValueSql { get; set; }
    }
}
