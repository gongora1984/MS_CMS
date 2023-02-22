namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseCourt : Entity, IAuditableEntity
    {
        public CaseCourt()
        {
            CaseJudges = new HashSet<CaseJudge>();
            CaseWrits = new HashSet<CaseWrit>();
        }

        public string CourtName { get; set; } = null!;
        public string? CountOfficalName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? ClerkContact { get; set; }
        public string? CourtCurcit { get; set; }
        public string? PstcurcitCode { get; set; }
        public string? CourtNotes { get; set; }
        public string? Website { get; set; }
        public int CaseCountyId { get; set; }
        public int? CaseDistrictId { get; set; }
        public int? CourtTypeLid { get; set; }

        public virtual CaseCounty CaseCounty { get; set; } = null!;
        public virtual CaseDistrict? CaseDistrict { get; set; }
        public virtual ListItem? CourtType { get; set; }
        public virtual ICollection<CaseJudge> CaseJudges { get; set; }
        public virtual ICollection<CaseWrit> CaseWrits { get; set; }
    }
}
