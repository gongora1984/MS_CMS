using CMSSERVICE.DOMAIN.Primitives;

namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseState : Entity, IAuditableEntity
    {
        public CaseState()
        {
            CaseCounties = new HashSet<CaseCounty>();
            CaseDistricts = new HashSet<CaseDistrict>();
            CaseFcls = new HashSet<CaseFcl>();
            CaseReplevins = new HashSet<CaseReplevin>();
        }

        public int CaseStateId { get; set; }
        public string StateAbbrev { get; set; } = null!;
        public string StateName { get; set; } = null!;

        public virtual ICollection<CaseCounty> CaseCounties { get; set; }
        public virtual ICollection<CaseDistrict> CaseDistricts { get; set; }
        public virtual ICollection<CaseFcl> CaseFcls { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevins { get; set; }
    }
}
