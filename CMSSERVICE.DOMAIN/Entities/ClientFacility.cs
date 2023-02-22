namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientFacility : Entity, IAuditableEntity
    {
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? FacilityState { get; set; }
        public string? Email { get; set; }
        public int FacilityTypeLid { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ListItem FacilityType { get; set; } = null!;
    }
}
