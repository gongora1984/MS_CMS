namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class DocumentNote : Entity, IAuditableEntity
    {
        public DateTime NoteOn { get; set; }
        public string NoteText { get; set; } = null!;
        public int LoginDetailId { get; set; }
        public int DocumentRepositoryId { get; set; }

        public virtual DocumentRepository DocumentRepository { get; set; } = null!;
        public virtual LoginDetail LoginDetail { get; set; } = null!;
    }
}
