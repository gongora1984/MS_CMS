namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseColDefendantBankInfo : Entity, IAuditableEntity
    {
        public string? Bank { get; set; }
        public string? RountingNumber { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountNumberLast4 { get; set; }
        public bool IsDeleted { get; set; }
        public string? TransactionType { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public DateTime? LastVerifiedDate { get; set; }
        public bool? IsDefault { get; set; }
        public string? NameOnAccount { get; set; }
        public int CaseJobDefendantId { get; set; }
        public int? AccountTypeLid { get; set; }

        public virtual ListItem? AccountType { get; set; }
        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
    }
}
