﻿namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class CaseSubpoenaOrderInfo : Entity, IAuditableEntity
    {
        public DateTime? RequestedDateFrom { get; set; }
        public DateTime? RequestedDateTo { get; set; }
        public DateTime? InformationReceivedDate { get; set; }
        public DateTime? InformationRequestedDate { get; set; }
        public string? InformationRequestedComment { get; set; }
        public string? InformationRequestedStatusComment { get; set; }
        public string? AdditionalComments { get; set; }
        public int? AccountNumber { get; set; }
        public string? IntegrationId { get; set; }
        public int CaseSubpoenaId { get; set; }
        public int? InformationRequestedLid { get; set; }
        public int? InformationRequestedStatusLid { get; set; }
        public int? IsOrderAskingForRecordsLid { get; set; }

        public virtual CaseSubpoena CaseSubpoena { get; set; } = null!;
        public virtual ListItem? InformationRequested { get; set; }
        public virtual ListItem? InformationRequestedStatus { get; set; }
        public virtual ListItem? IsOrderAskingForRecords { get; set; }
    }
}
