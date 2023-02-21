using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class Bkrjournal : Entity, IAuditableEntity
    {
        public int BkrjourneyId { get; set; }
        public string? OtherKey { get; set; }
        public DateTime JournalDate { get; set; }
        public string Action { get; set; } = null!;
        public int CaseBkrid { get; set; }

        public virtual CaseBkr CaseBkr { get; set; } = null!;
    }
}
