namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrFinOtherCost : Entity, IAuditableEntity
    {
        public string? CostName { get; set; }
        public decimal CostAmount { get; set; }
        public string? DateIncurred { get; set; }
        public string? OtherDescription { get; set; }
        public int? SupportDocumentRepositoryId { get; set; }
        public bool Lpapproved { get; set; }
        public bool ClientApproved { get; set; }
        public DateTime? WriteOffDate { get; set; }
        public string? WriteOffNote { get; set; }
        public int? WriteOffBy { get; set; }
        public string? ActionNeededNote { get; set; }
        public int CaseBkrId { get; set; }
        public int CostDecriptionLid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
        public virtual ListItem CostDecription { get; set; } = null!;
    }
}
