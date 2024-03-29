﻿namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseTitleReRecorded : Entity, IAuditableEntity
    {
        public DateTime ReRecorderDate { get; set; }
        public string? Book { get; set; }
        public string? Page { get; set; }
        public string? Instrument { get; set; }
        public int CaseTitleId { get; set; }

        public virtual CaseTitle CaseTitle { get; set; } = null!;
    }
}
