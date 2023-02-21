namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class BkrFinInterestRate : Entity, IAuditableEntity
    {
        public DateTime? IrfromDate { get; set; }
        public DateTime? IttoDate { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? Irtotal { get; set; }
        public bool? IsFixedRate { get; set; }
        public bool? IsVariableRate { get; set; }
        public int CaseBkrId { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
