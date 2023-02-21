using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CientJobLog : Entity, IAuditableEntity
    {
        public int CientJobLogId { get; set; }
        public DateTime LogDate { get; set; }
        public string LogText { get; set; } = null!;
        public int ClientJobId { get; set; }

        public virtual ClientJob ClientJob { get; set; } = null!;
    }
}
