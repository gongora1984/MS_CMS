namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class Garnishee : Entity, IAuditableEntity
    {
        public Garnishee()
        {
            CaseWrits = new HashSet<CaseWrit>();
        }

        public string GarnisheeName { get; set; } = null!;
        public string? GarnisheeAddress1 { get; set; }
        public string? GarnisheeAddress2 { get; set; }
        public string? GarnisheeCity { get; set; }
        public string? GarnisheeState { get; set; }
        public string? GarnisheeZip { get; set; }
        public string? GarnisheePhone { get; set; }
        public string? GarnisheeFax { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<CaseWrit> CaseWrits { get; set; }
    }
}
