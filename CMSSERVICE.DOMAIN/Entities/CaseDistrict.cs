namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseDistrict : Entity, IAuditableEntity
    {
        public CaseDistrict()
        {
            CaseCourts = new HashSet<CaseCourt>();
            CaseEvictions = new HashSet<CaseEviction>();
            CaseReplevins = new HashSet<CaseReplevin>();
        }

        public string DistrictName { get; set; } = null!;
        public int ListOrder { get; set; }
        public int CaseStateId { get; set; }

        public virtual CaseState CaseState { get; set; } = null!;
        public virtual ICollection<CaseCourt> CaseCourts { get; set; }
        public virtual ICollection<CaseEviction> CaseEvictions { get; set; }
        public virtual ICollection<CaseReplevin> CaseReplevins { get; set; }
    }
}
