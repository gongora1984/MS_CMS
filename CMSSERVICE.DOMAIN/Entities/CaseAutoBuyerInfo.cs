namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseAutoBuyerInfo : Entity, IAuditableEntity
    {
        public string BuyerName { get; set; } = null!;
        public string? EmailAddress { get; set; }
        public int? BackgroundCheckLid { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AltPhoneNum { get; set; }
        public int? DriverLicenseDocRepId { get; set; }
        public string? DlexpiryDate { get; set; }
        public int? BuyingActionLid { get; set; }
        public int? OnlinePlacementLid { get; set; }
        public int? AssignedAgentLid { get; set; }
        public bool? IsAgentNotified { get; set; }
        public int? BuyingStatusLid { get; set; }
        public int? TestDriveResultsLid { get; set; }
        public string? FollowUpDate { get; set; }
        public string? FollowUpComment { get; set; }
        public int? CreatedBy { get; set; }
        public string? CreatedOn { get; set; }
        public string? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ClientJobId { get; set; }
        public string? TestDriveDate { get; set; }
        public int CaseAutoId { get; set; }
        public virtual CaseAuto CaseAuto { get; set; } = null!;
    }
}
