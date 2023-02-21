namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseColTransaction : Entity, IAuditableEntity
    {
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; } = null!;
        public string TransactionType { get; set; } = null!;
        public decimal TransactionAmount { get; set; }
        public decimal Balance { get; set; }
        public string TallyCode { get; set; } = null!;
        public bool? Tally { get; set; }
        public decimal AppCost { get; set; }
        public decimal AppPrince { get; set; }
        public decimal AppInterest { get; set; }
        public decimal AppOther { get; set; }
        public decimal AppFees { get; set; }
        public int? PaidbyDefendantId { get; set; }
        public int CaseColid { get; set; }

        public virtual CaseCol CaseCol { get; set; } = null!;
    }
}
