using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseCounty : Entity, IAuditableEntity
    {
        public CaseCounty()
        {
            CaseCourts = new HashSet<CaseCourt>();
            CaseEvictions = new HashSet<CaseEviction>();
            CaseFcls = new HashSet<CaseFcl>();
            CaseMasters = new HashSet<CaseMaster>();
            CaseReplevinCountyFileds = new HashSet<CaseReplevin>();
            CaseReplevinDebtorCounties = new HashSet<CaseReplevin>();
            CaseWrits = new HashSet<CaseWrit>();
        }

        public int CaseCountyId { get; set; }
        public string County { get; set; } = null!;
        public int CaseStateId { get; set; }

        public virtual CaseState CaseState { get; set; } = null!;
        public virtual ICollection<CaseCourt> CaseCourts { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictions { get; set; }
        public virtual ICollection<CaseFcl> CaseFcls { get; set; }
        public virtual ICollection<CaseMaster> CaseMasters { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinCountyFileds { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevinDebtorCounties { get; set; }
        public virtual ICollection<CaseWrit> CaseWrits { get; set; }
    }
}
