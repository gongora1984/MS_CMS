namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseSalePubDate : Entity, IAuditableEntity
    {
        public int CaseSaleId { get; set; }
        public DateTime PubDate { get; set; }
        public int RunOrder { get; set; }

        public string? PubCompany { get; set; }

        public virtual CaseSale CaseSale { get; set; } = null!;
    }
}
