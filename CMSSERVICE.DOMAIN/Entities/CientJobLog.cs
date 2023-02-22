namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CientJobLog : Entity, IAuditableEntity
    {
        public DateTime LogDate { get; set; }
        public string LogText { get; set; } = null!;
        public int ClientJobId { get; set; }

        public virtual ClientJob ClientJob { get; set; } = null!;
    }
}
