namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseSale : Entity, IAuditableEntity
    {
        public CaseSale()
        {
            CaseSalePubCosts = new HashSet<CaseSalePubCost>();
            CaseSalePubDates = new HashSet<CaseSalePubDate>();
        }

        public int CaseFclid { get; set; }
        public decimal? BidAmt { get; set; }
        public decimal? SaleAmt { get; set; }
        public string? SaleDate { get; set; }
        public string? BidAssign { get; set; }
        public string? BidAssignAddr { get; set; }
        public string? BidAssignCity { get; set; }
        public string? BidAssignState { get; set; }
        public string? BidAssignZip { get; set; }
        public int? BidAssignedToId { get; set; }
        public string? Bidder { get; set; }
        public decimal? SuppJudgRecov { get; set; }
        public bool? Active { get; set; }
        public string? Comments { get; set; }
        public DateTime? PreSaleDate { get; set; }
        public DateTime? PreSalePubRunDate1 { get; set; }
        public DateTime? PreSalePubRunDate2 { get; set; }
        public DateTime? PreSaleReqBidInst { get; set; }
        public DateTime? SaleHeldDate { get; set; }
        public decimal? SaleHeldBidAmt { get; set; }
        public string? SaleHeldBidInst { get; set; }
        public string? SaleHeldBidder { get; set; }
        public DateTime? PostSalesCertofSales { get; set; }
        public DateTime? PostSalesCertofTitle { get; set; }
        public decimal? PostSales3rdFunds { get; set; }
        public DateTime? PostSales3rdFundsRec { get; set; }
        public DateTime? PostSalesObjection { get; set; }
        public DateTime? PostSalesCtrecorded { get; set; }
        public DateTime? PostSalesAmndCtrecorded { get; set; }
        public string? PerDiem { get; set; }
        public string? TotalInterestDue { get; set; }
        public string? RescheduleDate { get; set; }
        public int? IntDays { get; set; }
        public decimal? TotalCosts { get; set; }
        public string? IntegrationId1 { get; set; }
        public string? IntegrationId2 { get; set; }
        public int? IntegrationId3 { get; set; }
        public int? RescheduleReasonLid { get; set; }
        public int? CancelReasonLid { get; set; }
        public int CaseSaleStatusLid { get; set; }

        public virtual ListItem? CancelReason { get; set; }
        public virtual CaseFcl CaseFcl { get; set; } = null!;
        public virtual ListItem CaseSaleStatus { get; set; } = null!;
        public virtual ListItem? RescheduleReason { get; set; }
        public virtual ICollection<CaseSalePubCost> CaseSalePubCosts { get; set; }
        public virtual ICollection<CaseSalePubDate> CaseSalePubDates { get; set; }
    }
}
