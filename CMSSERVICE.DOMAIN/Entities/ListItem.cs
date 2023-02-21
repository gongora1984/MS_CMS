using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ListItem : Entity, IAuditableEntity
    {
        public ListItem()
        {
            BkrfinOtherCosts = new HashSet<BkrfinOtherCost>();
            CaseAutoAssignedCsrls = new HashSet<CaseAuto>();
            CaseAutoCaseAutoStatusLs = new HashSet<CaseAuto>();
            CaseAutoClosedReasonLs = new HashSet<CaseAuto>();
            CaseAutoVehicleStatusLs = new HashSet<CaseAuto>();
            CaseBkrBkrcircuitLs = new HashSet<CaseBkr>();
            CaseBkrBkrsolls = new HashSet<CaseBkr>();
            CaseBkrCaseBkrclientInvestorLs = new HashSet<CaseBkr>();
            CaseBkrCaseBkrclientInvestorTypeLs = new HashSet<CaseBkr>();
            CaseBkrCaseBkrstatusLs = new HashSet<CaseBkr>();
            CaseBkrCaseBkrtypeLs = new HashSet<CaseBkr>();
            CaseBkrClosedReasonLs = new HashSet<CaseBkr>();
            CaseColCaseColcloseReasonLs = new HashSet<CaseCol>();
            CaseColCaseColstatusLs = new HashSet<CaseCol>();
            CaseColdefendantBankInfos = new HashSet<CaseColdefendantBankInfo>();
            CaseColdefendantCardInfos = new HashSet<CaseColdefendantCardInfo>();
            CaseCommentWhiteboards = new HashSet<CaseCommentWhiteboard>();
            CaseComments = new HashSet<CaseComment>();
            CaseCourts = new HashSet<CaseCourt>();
            CaseEvictionCircuitLs = new HashSet<CaseEviction>();
            CaseEvictionClosedReasonLs = new HashSet<CaseEviction>();
            CaseEvictionDivisionLs = new HashSet<CaseEviction>();
            CaseEvictionEvictionStatusLs = new HashSet<CaseEviction>();
            CaseEvictionEvictionTypeLs = new HashSet<CaseEviction>();
            CaseFclCaseFclcaseTypeLs = new HashSet<CaseFcl>();
            CaseFclCaseFclclientInvestorTypeLs = new HashSet<CaseFcl>();
            CaseFclCaseFclclosedReasonLs = new HashSet<CaseFcl>();
            CaseFclCaseFclpropertyTypeLs = new HashSet<CaseFcl>();
            CaseFclCaseFclstatusLs = new HashSet<CaseFcl>();
            CaseJobDefendantByVirtueOfs = new HashSet<CaseJobDefendantByVirtueOf>();
            CaseJobDefendantPartyTypeLs = new HashSet<CaseJobDefendant>();
            CaseJobDefendantRequestorOrganizationLs = new HashSet<CaseJobDefendant>();
            CaseJobDefendantSearchHistories = new HashSet<CaseJobDefendantSearchHistory>();
            CaseJobDefendantServiceServiceStatusLs = new HashSet<CaseJobDefendantService>();
            CaseJobDefendantServiceServiceTypeLs = new HashSet<CaseJobDefendantService>();
            CaseJobDefendantServiceTypeLs = new HashSet<CaseJobDefendant>();
            CaseReplevinCaseReplevinStatusLs = new HashSet<CaseReplevin>();
            CaseReplevinCaseReplevinTypeLs = new HashSet<CaseReplevin>();
            CaseReplevinClosedReasonLs = new HashSet<CaseReplevin>();
            CaseReplevinDefaultReasonLs = new HashSet<CaseReplevin>();
            CaseReplevinInvestorTypeLs = new HashSet<CaseReplevin>();
            CaseReplevinOccupancyStatusLs = new HashSet<CaseReplevin>();
            CaseSaleCancelReasonLs = new HashSet<CaseSale>();
            CaseSaleCaseSaleStatusLs = new HashSet<CaseSale>();
            CaseSaleRescheduleReasonLs = new HashSet<CaseSale>();
            CaseSubpoenaCaseSubpoenaClosedReasonLs = new HashSet<CaseSubpoena>();
            CaseSubpoenaCaseSubpoenaDocTransmissionMethodLs = new HashSet<CaseSubpoena>();
            CaseSubpoenaCaseSubpoenaPcidataIncludedLs = new HashSet<CaseSubpoena>();
            CaseSubpoenaCaseSubpoenaStatusLs = new HashSet<CaseSubpoena>();
            CaseSubpoenaCaseSubpoenaSubTypeLs = new HashSet<CaseSubpoena>();
            CaseSubpoenaCaseSubpoenaTypeLs = new HashSet<CaseSubpoena>();
            CaseSubpoenaOrderInfoInformationRequestedLs = new HashSet<CaseSubpoenaOrderInfo>();
            CaseSubpoenaOrderInfoInformationRequestedStatusLs = new HashSet<CaseSubpoenaOrderInfo>();
            CaseSubpoenaOrderInfoIsOrderAskingForRecordsLs = new HashSet<CaseSubpoenaOrderInfo>();
            CaseTitleCaseTitleStatusLs = new HashSet<CaseTitle>();
            CaseTitleClientInvestorTypeLs = new HashSet<CaseTitle>();
            CaseTitleMortgTaxLiens = new HashSet<CaseTitleMortgTaxLien>();
            CaseTitleMortgagePositionLs = new HashSet<CaseTitle>();
            CaseTitleSpecialCountTemplates = new HashSet<CaseTitleSpecialCountTemplate>();
            CaseTitleTitleCompanyLs = new HashSet<CaseTitle>();
            CaseTitleTypeOfMortLs = new HashSet<CaseTitle>();
            CaseTitleUnderwriterLs = new HashSet<CaseTitle>();
            CaseWritAdditionalDocumentationLs = new HashSet<CaseWrit>();
            CaseWritCaseDetailLs = new HashSet<CaseWrit>();
            CaseWritCaseTypeLs = new HashSet<CaseWrit>();
            CaseWritCaseWritStatusLs = new HashSet<CaseWrit>();
            CaseWritClosedReasonLs = new HashSet<CaseWrit>();
            CaseWritFinancialAcctStatusLs = new HashSet<CaseWritFinancial>();
            CaseWritFinancialAcctStylingLs = new HashSet<CaseWritFinancial>();
            CaseWritRtgLs = new HashSet<CaseWrit>();
            ClientAssignmentHolds = new HashSet<ClientAssignmentHold>();
            ClientAssignmentTaskCheckLists = new HashSet<ClientAssignmentTaskCheckList>();
            ClientFacilities = new HashSet<ClientFacility>();
            ClientJobLegals = new HashSet<ClientJobLegal>();
            Clients = new HashSet<Client>();
            DocumentMailOutHistoryMailServiceTypeLs = new HashSet<DocumentMailOutHistory>();
            DocumentMailOutHistoryMailVendorLs = new HashSet<DocumentMailOutHistory>();
            DocumentRepositories = new HashSet<DocumentRepository>();
            DocumentTypes = new HashSet<DocumentType>();
            LawPractices = new HashSet<LawPractice>();
            LoginDetails = new HashSet<LoginDetail>();
            LoginDetailsAccessRoles = new HashSet<LoginDetailsAccessRole>();
        }

        public int ListItemId { get; set; }
        public int ClientId { get; set; }
        public int LawPracticeId { get; set; }
        public string SystemCategory { get; set; } = null!;
        public string SystemTag { get; set; } = null!;
        public string DisplayText { get; set; } = null!;
        public string? Value1 { get; set; }
        public string? Value2 { get; set; }
        public int ListOrder { get; set; }
        public bool? Enabled { get; set; }
        public string? DefValue1 { get; set; }
        public string? DefValue2 { get; set; }
        public string? DefValue3 { get; set; }
        public string? DefValue4 { get; set; }
        public string? DefValue5 { get; set; }
        public string? DefValue6 { get; set; }
        public int? DefaultDateDays { get; set; }
        public string? MergeText { get; set; }
        public string? MergeValue { get; set; }
        public string? InvokeAssignment { get; set; }

        public virtual ICollection<BkrfinOtherCost> BkrfinOtherCosts { get; set; }
        public virtual ICollection<CaseAuto> CaseAutoAssignedCsrls { get; set; }
        public virtual ICollection<CaseAuto> CaseAutoCaseAutoStatusLs { get; set; }
        public virtual ICollection<CaseAuto> CaseAutoClosedReasonLs { get; set; }
        public virtual ICollection<CaseAuto> CaseAutoVehicleStatusLs { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrBkrcircuitLs { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrBkrsolls { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrCaseBkrclientInvestorLs { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrCaseBkrclientInvestorTypeLs { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrCaseBkrstatusLs { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrCaseBkrtypeLs { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrClosedReasonLs { get; set; }
        public virtual ICollection<CaseCol> CaseColCaseColcloseReasonLs { get; set; }
        public virtual ICollection<CaseCol> CaseColCaseColstatusLs { get; set; }
        public virtual ICollection<CaseColdefendantBankInfo> CaseColdefendantBankInfos { get; set; }
        public virtual ICollection<CaseColdefendantCardInfo> CaseColdefendantCardInfos { get; set; }
        public virtual ICollection<CaseCommentWhiteboard> CaseCommentWhiteboards { get; set; }
        public virtual ICollection<CaseComment> CaseComments { get; set; }
        public virtual ICollection<CaseCourt> CaseCourts { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictionCircuitLs { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictionClosedReasonLs { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictionDivisionLs { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictionEvictionStatusLs { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictionEvictionTypeLs { get; set; }
        public virtual ICollection<CaseFcl> CaseFclCaseFclcaseTypeLs { get; set; }
        public virtual ICollection<CaseFcl> CaseFclCaseFclclientInvestorTypeLs { get; set; }
        public virtual ICollection<CaseFcl> CaseFclCaseFclclosedReasonLs { get; set; }
        public virtual ICollection<CaseFcl> CaseFclCaseFclpropertyTypeLs { get; set; }
        public virtual ICollection<CaseFcl> CaseFclCaseFclstatusLs { get; set; }
        public virtual ICollection<CaseJobDefendantByVirtueOf> CaseJobDefendantByVirtueOfs { get; set; }
        public virtual ICollection<CaseJobDefendant> CaseJobDefendantPartyTypeLs { get; set; }
        public virtual ICollection<CaseJobDefendant> CaseJobDefendantRequestorOrganizationLs { get; set; }
        public virtual ICollection<CaseJobDefendantSearchHistory> CaseJobDefendantSearchHistories { get; set; }
        public virtual ICollection<CaseJobDefendantService> CaseJobDefendantServiceServiceStatusLs { get; set; }
        public virtual ICollection<CaseJobDefendantService> CaseJobDefendantServiceServiceTypeLs { get; set; }
        public virtual ICollection<CaseJobDefendant> CaseJobDefendantServiceTypeLs { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinCaseReplevinStatusLs { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinCaseReplevinTypeLs { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinClosedReasonLs { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinDefaultReasonLs { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinInvestorTypeLs { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinOccupancyStatusLs { get; set; }
        public virtual ICollection<CaseSale> CaseSaleCancelReasonLs { get; set; }
        public virtual ICollection<CaseSale> CaseSaleCaseSaleStatusLs { get; set; }
        public virtual ICollection<CaseSale> CaseSaleRescheduleReasonLs { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaCaseSubpoenaClosedReasonLs { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaCaseSubpoenaDocTransmissionMethodLs { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaCaseSubpoenaPcidataIncludedLs { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaCaseSubpoenaStatusLs { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaCaseSubpoenaSubTypeLs { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenaCaseSubpoenaTypeLs { get; set; }
        public virtual ICollection<CaseSubpoenaOrderInfo> CaseSubpoenaOrderInfoInformationRequestedLs { get; set; }
        public virtual ICollection<CaseSubpoenaOrderInfo> CaseSubpoenaOrderInfoInformationRequestedStatusLs { get; set; }
        public virtual ICollection<CaseSubpoenaOrderInfo> CaseSubpoenaOrderInfoIsOrderAskingForRecordsLs { get; set; }
        public virtual ICollection<CaseTitle> CaseTitleCaseTitleStatusLs { get; set; }
        public virtual ICollection<CaseTitle> CaseTitleClientInvestorTypeLs { get; set; }
        public virtual ICollection<CaseTitleMortgTaxLien> CaseTitleMortgTaxLiens { get; set; }
        public virtual ICollection<CaseTitle> CaseTitleMortgagePositionLs { get; set; }
        public virtual ICollection<CaseTitleSpecialCountTemplate> CaseTitleSpecialCountTemplates { get; set; }
        public virtual ICollection<CaseTitle> CaseTitleTitleCompanyLs { get; set; }
        public virtual ICollection<CaseTitle> CaseTitleTypeOfMortLs { get; set; }
        public virtual ICollection<CaseTitle> CaseTitleUnderwriterLs { get; set; }
        public virtual ICollection<CaseWrit> CaseWritAdditionalDocumentationLs { get; set; }
        public virtual ICollection<CaseWrit> CaseWritCaseDetailLs { get; set; }
        public virtual ICollection<CaseWrit> CaseWritCaseTypeLs { get; set; }
        public virtual ICollection<CaseWrit> CaseWritCaseWritStatusLs { get; set; }
        public virtual ICollection<CaseWrit> CaseWritClosedReasonLs { get; set; }
        public virtual ICollection<CaseWritFinancial> CaseWritFinancialAcctStatusLs { get; set; }
        public virtual ICollection<CaseWritFinancial> CaseWritFinancialAcctStylingLs { get; set; }
        public virtual ICollection<CaseWrit> CaseWritRtgLs { get; set; }
        public virtual ICollection<ClientAssignmentHold> ClientAssignmentHolds { get; set; }
        public virtual ICollection<ClientAssignmentTaskCheckList> ClientAssignmentTaskCheckLists { get; set; }
        public virtual ICollection<ClientFacility> ClientFacilities { get; set; }
        public virtual ICollection<ClientJobLegal> ClientJobLegals { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<DocumentMailOutHistory> DocumentMailOutHistoryMailServiceTypeLs { get; set; }
        public virtual ICollection<DocumentMailOutHistory> DocumentMailOutHistoryMailVendorLs { get; set; }
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public virtual ICollection<LawPractice> LawPractices { get; set; }
        public virtual ICollection<LoginDetail> LoginDetails { get; set; }
        public virtual ICollection<LoginDetailsAccessRole> LoginDetailsAccessRoles { get; set; }
    }
}
