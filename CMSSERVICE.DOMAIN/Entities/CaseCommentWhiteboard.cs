namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseCommentWhiteboard : Entity, IAuditableEntity
    {
        public string CommentText { get; set; } = null!;
        public int? ClientJobId { get; set; }
        public int CaseId { get; set; }
        public int CommentTypeLid { get; set; }

        public virtual CaseMaster Case { get; set; } = null!;
        public virtual ClientJob? ClientJob { get; set; }
        public virtual ListItem CommentType { get; set; } = null!;
    }
}
