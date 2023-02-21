using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseAuto : Entity, IAuditableEntity
    {
        public CaseAuto()
        {
            CaseAutoBuyerInfos = new HashSet<CaseAutoBuyerInfo>();
        }

        public int CaseAutoId { get; set; }
        public string? VehicleVinNumber { get; set; }
        public string? VehicleMake { get; set; }
        public string? VehicleModel { get; set; }
        public string? VehicleYear { get; set; }
        public string? VehicleTrim { get; set; }
        public string? LpreferenceId { get; set; }
        public string? InternalStockRefNum { get; set; }
        public DateTime? DateListed { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public decimal? GuaranteedAmount { get; set; }
        public int? Mileage { get; set; }
        public string? Location { get; set; }
        public decimal? MmrestimatedValue { get; set; }
        public decimal? RetailValue { get; set; }
        public decimal? SalePrice { get; set; }
        public string? TitleTransferDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? OpenedDate { get; set; }
        public int ClientJobId { get; set; }
        public int CaseAutoStatusLid { get; set; }
        public int? AssignedCsrlid { get; set; }
        public int? VehicleStatusLid { get; set; }
        public int? ClosedReasonLid { get; set; }

        public virtual ListItem? AssignedCsrl { get; set; }
        public virtual ListItem CaseAutoStatusL { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? ClosedReasonL { get; set; }
        public virtual ListItem? VehicleStatusL { get; set; }
        public virtual ICollection<CaseAutoBuyerInfo> CaseAutoBuyerInfos { get; set; }
    }
}
