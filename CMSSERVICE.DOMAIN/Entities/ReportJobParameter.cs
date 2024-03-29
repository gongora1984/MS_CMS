﻿namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class ReportJobParameter : Entity, IAuditableEntity
    {
        public string Value { get; set; } = null!;
        public int ReportJobId { get; set; }
        public int ReportParameterId { get; set; }

        public virtual ReportJob ReportJob { get; set; } = null!;
        public virtual ReportParameter ReportParameter { get; set; } = null!;
    }
}
