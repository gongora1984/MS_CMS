using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ClientJob : Entity, IAuditableEntity
    {
        public ClientJob()
        {
            CaseAutos = new HashSet<CaseAuto>();
            CaseBkrs = new HashSet<CaseBkr>();
            CaseCols = new HashSet<CaseCol>();
            CaseCommentWhiteboards = new HashSet<CaseCommentWhiteboard>();
            CaseComments = new HashSet<CaseComment>();
            CaseEvictions = new HashSet<CaseEviction>();
            CaseFcls = new HashSet<CaseFcl>();
            CaseJobDefendants = new HashSet<CaseJobDefendant>();
            CaseReplevins = new HashSet<CaseReplevin>();
            CaseSubpoenas = new HashSet<CaseSubpoena>();
            CaseWrits = new HashSet<CaseWrit>();
            CientJobLogs = new HashSet<CientJobLog>();
            ClientAssignmentScheduleds = new HashSet<ClientAssignmentScheduled>();
            ClientAssignments = new HashSet<ClientAssignment>();
            ClientJobActivities = new HashSet<ClientJobActivity>();
            ClientJobLegals = new HashSet<ClientJobLegal>();
            DocumentMailOutHistories = new HashSet<DocumentMailOutHistory>();
            DocumentRepositories = new HashSet<DocumentRepository>();
        }

        public int ClientJobId { get; set; }

        /// <summary>
        /// Gets or sets get - This column represents the module id( casebkyid, casewritid).
        /// </summary>
        public int JobDataKeyId { get; set; }
        public string? LpreferranceNumber { get; set; }
        public string? ReferralAcknolagedDate { get; set; }
        public string? ClientJobStatus { get; set; }
        public string? ClosedDate { get; set; }
        public int CaseId { get; set; }
        public int? LawPracticeId { get; set; }
        public int? LocalCounselId { get; set; }
        public int JobTypeId { get; set; }

        public virtual CaseMaster Case { get; set; } = null!;
        public virtual JobType JobType { get; set; } = null!;
        public virtual LawPractice? LawPractice { get; set; }
        public virtual LocalCounsel? LocalCounsel { get; set; }
        public virtual ICollection<CaseAuto> CaseAutos { get; set; }
        public virtual ICollection<CaseBkr> CaseBkrs { get; set; }
        public virtual ICollection<CaseCol> CaseCols { get; set; }
        public virtual ICollection<CaseCommentWhiteboard> CaseCommentWhiteboards { get; set; }
        public virtual ICollection<CaseComment> CaseComments { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictions { get; set; }
        public virtual ICollection<CaseFcl> CaseFcls { get; set; }
        public virtual ICollection<CaseJobDefendant> CaseJobDefendants { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevins { get; set; }
        public virtual ICollection<CaseSubpoena> CaseSubpoenas { get; set; }
        public virtual ICollection<CaseWrit> CaseWrits { get; set; }
        public virtual ICollection<CientJobLog> CientJobLogs { get; set; }
        public virtual ICollection<ClientAssignmentScheduled> ClientAssignmentScheduleds { get; set; }
        public virtual ICollection<ClientAssignment> ClientAssignments { get; set; }
        public virtual ICollection<ClientJobActivity> ClientJobActivities { get; set; }
        public virtual ICollection<ClientJobLegal> ClientJobLegals { get; set; }
        public virtual ICollection<DocumentMailOutHistory> DocumentMailOutHistories { get; set; }
        public virtual ICollection<DocumentRepository> DocumentRepositories { get; set; }
    }
}
