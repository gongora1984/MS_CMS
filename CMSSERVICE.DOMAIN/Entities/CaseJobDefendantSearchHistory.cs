using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseJobDefendantSearchHistory : Entity, IAuditableEntity
    {
        public int CaseJobDefendantSearchHistoryId { get; set; }
        public string CameFrom { get; set; } = null!;
        public DateTime SentOutDate { get; set; }
        public string? SendOutRequest { get; set; }
        public DateTime? ResponseReceivedOn { get; set; }
        public string? ResponseReceived { get; set; }
        public int? CameFromAssignmentId { get; set; }
        public int CaseJobDefendantSearchTypeLid { get; set; }
        public int CaseJobDefendantId { get; set; }

        public virtual ClientAssignment? CameFromAssignment { get; set; }
        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
        public virtual ListItem CaseJobDefendantSearchTypeL { get; set; } = null!;
    }
}
