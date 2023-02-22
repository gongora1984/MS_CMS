namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseMaster : Entity, IAuditableEntity
    {
        public CaseMaster()
        {
            CaseCommentWhiteboards = new HashSet<CaseCommentWhiteboard>();
            CaseComments = new HashSet<CaseComment>();
            ClientJobs = new HashSet<ClientJob>();
        }

        public string CaseReferance { get; set; } = null!;
        public string ClientReferance { get; set; } = null!;
        public string ClientInternalRef { get; set; } = null!;
        public string? JobRecipientName { get; set; }
        public string? RecipientAdd1 { get; set; }
        public string? RecipientAdd2 { get; set; }
        public string? RecipientCity { get; set; }
        public string? RecipientState { get; set; }
        public string? RecipientZip { get; set; }
        public string State { get; set; } = null!;
        public int ClientId { get; set; }
        public int CaseCountyId { get; set; }

        public virtual CaseCounty CaseCounty { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<CaseCommentWhiteboard> CaseCommentWhiteboards { get; set; }
        public virtual ICollection<CaseComment> CaseComments { get; set; }
        public virtual ICollection<ClientJob> ClientJobs { get; set; }
    }
}
