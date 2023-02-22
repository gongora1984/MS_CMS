namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class LogonDetailSubordinate : Entity, IAuditableEntity
    {
        public bool CanTakeAnyAssignment { get; set; }
        public bool? IsAvailible { get; set; }
        public int LoginDetailId { get; set; }
        public int SubordinateLoginDetailsId { get; set; }

        public virtual LoginDetail LoginDetail { get; set; } = null!;
        public virtual LoginDetail SubordinateLoginDetails { get; set; } = null!;
    }
}
