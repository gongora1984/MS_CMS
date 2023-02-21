using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseComment : Entity, IAuditableEntity
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; } = null!;
        public int? ClientJobId { get; set; }
        public int CaseId { get; set; }
        public int CommentTypeLid { get; set; }

        public virtual CaseMaster Case { get; set; } = null!;
        public virtual ClientJob? ClientJob { get; set; }
        public virtual ListItem CommentTypeL { get; set; } = null!;
    }
}
