using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientJobListing : Entity, IAuditableEntity
    {
        public int ClientJobListingId { get; set; }
        public string? StartAssignmentsOnReferral { get; set; }
        public int ClientId { get; set; }
        public int JobTypeId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual JobType JobType { get; set; } = null!;
    }
}
