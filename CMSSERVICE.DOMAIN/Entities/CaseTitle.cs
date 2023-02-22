namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitle : Entity, IAuditableEntity
    {
        public CaseTitle()
        {
            CaseTitleAssignments = new HashSet<CaseTitleAssignment>();
            CaseTitleDlinqTaxes = new HashSet<CaseTitleDlinqTax>();
            CaseTitleFileAssigns = new HashSet<CaseTitleFileAssign>();
            CaseTitleIrstaxLiens = new HashSet<CaseTitleIrstaxLien>();
            CaseTitleJudgmentLiens = new HashSet<CaseTitleJudgmentLien>();
            CaseTitleModParagraphs = new HashSet<CaseTitleModParagraph>();
            CaseTitleMortgTaxLiens = new HashSet<CaseTitleMortgTaxLien>();
            CaseTitleMortgWithAssignments = new HashSet<CaseTitleMortgWithAssignment>();
            CaseTitleReRecordeds = new HashSet<CaseTitleReRecorded>();
            CaseTitleSpecialCounts = new HashSet<CaseTitleSpecialCount>();
        }

        public int? LastPreparedBy { get; set; }
        public int? PreparedBy { get; set; }
        public DateTime? LastPreparedDate { get; set; }
        public DateTime? PreparedDate { get; set; }
        public bool? DueOnSale { get; set; }
        public bool? TitleClaims { get; set; }
        public bool? OpenLp { get; set; }
        public bool? NonForeclosableLiens { get; set; }
        public string? NonForeclosableLiensDetail { get; set; }
        public string? OpenLpDetail { get; set; }
        public string? TitleClaimsDetail { get; set; }
        public string? MobileHomeDescription { get; set; }
        public bool? MobileHomeDescriptionVarified { get; set; }
        public string? TitleTypeOfMortgage { get; set; }
        public bool? IsMultiplex { get; set; }
        public string? WhoSignedMortgage { get; set; }
        public string? WhoSignedNote { get; set; }
        public bool? LegalDescriptionIsGood { get; set; }
        public bool? InconsistantDates { get; set; }
        public bool? IsHomesteded { get; set; }
        public bool? IsMobilehome { get; set; }
        public bool? IsTaxRoll { get; set; }
        public DateTime? ValidUntiDate { get; set; }
        public DateTime? LastTisgeneratedDate { get; set; }
        public string? LastTisgeneratedBy { get; set; }
        public string? GenrlNotes { get; set; }
        public bool? NeedsReformation { get; set; }
        public string? NeedsReformationReason { get; set; }
        public bool? HasDelinquentTaxes { get; set; }
        public bool? HasAssignments { get; set; }
        public bool? HasMersassignment { get; set; }
        public string? PropelId { get; set; }
        public bool? TaxDeedApp { get; set; }
        public DateTime? TasSaleSched { get; set; }
        public string? SuperiorLiens { get; set; }
        public bool? GalNeeded { get; set; }
        public bool? ProbateNeeded { get; set; }
        public string? TitleClaimBody { get; set; }
        public string? TitleClaimPolicyNum { get; set; }
        public string? Njlot { get; set; }
        public string? Njblock { get; set; }
        public string? Njqualifier { get; set; }
        public bool? ModificationParaReviewed { get; set; }
        public string? DeedType { get; set; }
        public string? DeedGrantor { get; set; }
        public string? DeedGrantee { get; set; }
        public string? DeedBook { get; set; }
        public string? DeedPage { get; set; }
        public string? DeedIntrumentNo { get; set; }
        public DateTime? DeedRecordedOn { get; set; }
        public DateTime? DeedReRecordedOn { get; set; }
        public string? DeedReRecBook { get; set; }
        public string? DeedReRecPage { get; set; }
        public string? DeedReRecIntrumentNo { get; set; }
        public int? NumberOfUnits { get; set; }
        public string? TaxId { get; set; }
        public int? PropertyDistrictLid { get; set; }
        public string? TitleLegalDescription { get; set; }
        public string? TitleMortgagee { get; set; }
        public string? TitleMortgagor { get; set; }
        public DateTime? TitleMortExecutedDate { get; set; }
        public DateTime? TitleMortRecordedDate { get; set; }
        public string? TitleMortBook { get; set; }
        public string? TitleMortPage { get; set; }
        public string? TitleMortInstrumentNum { get; set; }
        public int? TitleUnderWriter { get; set; }
        public DateTime? ChainofTitleInfoDate { get; set; }
        public string? MortLegalDescriptionError { get; set; }
        public string? LeinLegalDescriptionError { get; set; }
        public string? OrderType { get; set; }
        public string? ProductType { get; set; }
        public string? IntegrationId1 { get; set; }
        public string? ServiceType { get; set; }
        public int CaseFclid { get; set; }
        public int? MortgagePositionLid { get; set; }
        public int? CurrentTisdocId { get; set; }
        public int? TitleCompanyLid { get; set; }
        public int? TypeOfMortLid { get; set; }
        public int? UnderwriterLid { get; set; }
        public int? CaseTitleStatusLid { get; set; }
        public int? ClientInvestorTypeLid { get; set; }

        public virtual CaseFcl CaseFcl { get; set; } = null!;
        public virtual ListItem? CaseTitleStatus { get; set; }
        public virtual ListItem? ClientInvestorType { get; set; }
        public virtual DocumentRepository? CurrentTisdoc { get; set; }
        public virtual ListItem? MortgagePosition { get; set; }
        public virtual ListItem? TitleCompany { get; set; }
        public virtual CaseTitleUnderWriter? TitleUnderWriterNavigation { get; set; }
        public virtual ListItem? TypeOfMort { get; set; }
        public virtual ListItem? Underwriter { get; set; }
        public virtual ICollection<CaseTitleAssignment> CaseTitleAssignments { get; set; }
        public virtual ICollection<CaseTitleDlinqTax> CaseTitleDlinqTaxes { get; set; }
        public virtual ICollection<CaseTitleFileAssign> CaseTitleFileAssigns { get; set; }
        public virtual ICollection<CaseTitleIrstaxLien> CaseTitleIrstaxLiens { get; set; }
        public virtual ICollection<CaseTitleJudgmentLien> CaseTitleJudgmentLiens { get; set; }
        public virtual ICollection<CaseTitleModParagraph> CaseTitleModParagraphs { get; set; }
        public virtual ICollection<CaseTitleMortgTaxLien> CaseTitleMortgTaxLiens { get; set; }
        public virtual ICollection<CaseTitleMortgWithAssignment> CaseTitleMortgWithAssignments { get; set; }
        public virtual ICollection<CaseTitleReRecorded> CaseTitleReRecordeds { get; set; }
        public virtual ICollection<CaseTitleSpecialCount> CaseTitleSpecialCounts { get; set; }
    }
}
