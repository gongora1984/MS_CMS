namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientJobLegal : Entity, IAuditableEntity
    {
        public string? LegalDescriptionOrid { get; set; }
        public string? LegalDescriptionCur { get; set; }
        public string? LegalDescBook { get; set; }
        public string? LegalDescPage { get; set; }
        public string? LegalDescInstrument { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public int ClientJobId { get; set; }
        public int? LegalDescFromLid { get; set; }
        public int? VerifiedBy { get; set; }

        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual ListItem? LegalDescFrom { get; set; }
        public virtual LoginDetail? VerifiedByNavigation { get; set; }
    }
}
