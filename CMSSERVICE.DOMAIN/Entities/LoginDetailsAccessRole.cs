namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LoginDetailsAccessRole : Entity, IAuditableEntity
    {
        public string AccessFieldName { get; set; } = null!;
        public string AccessFieldValue { get; set; } = null!;
        public string AccessFieldClass { get; set; } = null!;
        public int LoginDetailId { get; set; }
        public int AccessFieldLid { get; set; }

        public virtual ListItem AccessField { get; set; } = null!;
        public virtual LoginDetail LoginDetail { get; set; } = null!;
    }
}
