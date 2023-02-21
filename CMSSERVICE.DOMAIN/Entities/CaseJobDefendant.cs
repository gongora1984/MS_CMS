namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJobDefendant : Entity, IAuditableEntity
    {
        public CaseJobDefendant()
        {
            CaseColDefendantBankInfos = new HashSet<CaseColDefendantBankInfo>();
            CaseColDefendantCardInfos = new HashSet<CaseColDefendantCardInfo>();
            CaseJobDefendantAdditionalAddresses = new HashSet<CaseJobDefendantAdditionalAddress>();
            CaseJobDefendantByVirtueOfs = new HashSet<CaseJobDefendantByVirtueOf>();
            CaseJobDefendantSearchHistories = new HashSet<CaseJobDefendantSearchHistory>();
            CaseJobDefendantServices = new HashSet<CaseJobDefendantService>();
            ClientAssignments = new HashSet<ClientAssignment>();
            DefendantAddresses = new HashSet<DefendantAddress>();
            DocumentMailOutHistories = new HashSet<DocumentMailOutHistory>();
            DocumentRepositories = new HashSet<DocumentRepository>();
        }

        public int CaseJobDefendantId { get; set; }
        public int PartyTypeLid { get; set; }
        public bool? Active { get; set; }
        public string? DefendantName { get; set; }
        public string? DefendantSsn { get; set; }
        public DateTime? DefendantDob { get; set; }
        public DateTime? DefendantDod { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public bool? AddressVacant { get; set; }
        public string? DefendantAlius { get; set; }
        public string? CurrentWorkFlowId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? PartyTypeName { get; set; }
        public bool? HasAlternateAddress { get; set; }
        public int AttemptNum { get; set; }
        public bool? IsInternationalAddress { get; set; }
        public bool? StopMailToDefendant { get; set; }
        public int? IntegrationId3 { get; set; }
        public string? FaxNumber { get; set; }
        public DateTime? PacerSearchDate { get; set; }
        public string? PacerSearchResults { get; set; }
        public int? PacerDocumentId { get; set; }
        public int? ServiceTypeLid { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string? ServiceAddress1 { get; set; }
        public string? ServiceAddress2 { get; set; }
        public string? ServiceCity { get; set; }
        public string? ServiceState { get; set; }
        public string? ServiceZip { get; set; }
        public bool? SameasPropertyAddress { get; set; }
        public string? BusinessPhoneNum { get; set; }
        public int? RequestorOrganizationLid { get; set; }
        public string? OrganizationName { get; set; }
        public string? CaseNumber { get; set; }
        public string? DefendantSsn4 { get; set; }
        public string? IntegrationId { get; set; }
        public int ClientJobId { get; set; }
        public int? CaseJobDefendantAttyId { get; set; }

        public virtual CaseJobDefendantAtty? CaseJobDefendantAtty { get; set; }
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual DocumentRepository? PacerDocument { get; set; }
        public virtual ListItem PartyTypeL { get; set; } = null!;
        public virtual ListItem? RequestorOrganizationL { get; set; }
        public virtual ListItem? ServiceTypeL { get; set; }
        public virtual ICollection<CaseColDefendantBankInfo> CaseColDefendantBankInfos { get; set; }
        public virtual ICollection<CaseColDefendantCardInfo> CaseColDefendantCardInfos { get; set; }
        public virtual ICollection<CaseJobDefendantAdditionalAddress> CaseJobDefendantAdditionalAddresses { get; set; }
        public virtual ICollection<CaseJobDefendantByVirtueOf> CaseJobDefendantByVirtueOfs { get; set; }
        public virtual ICollection<CaseJobDefendantSearchHistory> CaseJobDefendantSearchHistories { get; set; }
        public virtual ICollection<CaseJobDefendantService> CaseJobDefendantServices { get; set; }
        public virtual ICollection<ClientAssignment> ClientAssignments { get; set; }
        public virtual ICollection<DefendantAddress> DefendantAddresses { get; set; }
        public virtual ICollection<DocumentMailOutHistory> DocumentMailOutHistories { get; set; }
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
    }
}
