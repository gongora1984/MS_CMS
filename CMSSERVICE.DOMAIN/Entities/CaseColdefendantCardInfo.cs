using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseColdefendantCardInfo : Entity, IAuditableEntity
    {
        public int CaseColdefendantCardInfoId { get; set; }
        public string Cctype { get; set; } = null!;
        public string Ccnumber { get; set; } = null!;
        public string CcnumberLast4 { get; set; } = null!;
        public string CcexpirationMm { get; set; } = null!;
        public string CcexpirationYy { get; set; } = null!;
        public string Cccvv { get; set; } = null!;
        public string Ccname { get; set; } = null!;
        public string Ccaddress { get; set; } = null!;
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastVerifiedDate { get; set; }
        public string? Cccity { get; set; }
        public string? Ccstate { get; set; }
        public string? CczipCode { get; set; }
        public string? TransactionType { get; set; }
        public string? NameOnAccount { get; set; }
        public int CaseJobDefendantId { get; set; }
        public int? AccountTypeLid { get; set; }

        public virtual ListItem? AccountTypeL { get; set; }
        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
    }
}
