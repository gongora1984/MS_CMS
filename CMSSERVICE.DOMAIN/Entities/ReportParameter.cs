namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ReportParameter : Entity, IAuditableEntity
    {
        public ReportParameter()
        {
            ReportJobParameters = new HashSet<ReportJobParameter>();
        }

        public string Name { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string ValueType { get; set; } = null!;
        public string? DefaultValue { get; set; }
        public int ReportId { get; set; }

        public virtual Report Report { get; set; } = null!;
        public virtual ICollection<ReportJobParameter> ReportJobParameters { get; set; }
    }
}
