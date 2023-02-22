namespace CMSSERVICE.DOMAIN.Entities
{
    public partial class DocumentMailOutHistory : Entity, IAuditableEntity
    {
        public DateTime SentOutDate { get; set; }
        public DateTime? VenderSentOut { get; set; }
        public string? RecipientName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public decimal? VenderPostageAmount { get; set; }
        public string? TrackingNumber { get; set; }
        public string? TrackingLastEntry { get; set; }
        public string? ReceiptId { get; set; }
        public bool? IsProcessed { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public string? VendorPostalServiceSent { get; set; }
        public decimal? VendorAdditionalCharge { get; set; }
        public decimal? VendorServiceCharge { get; set; }
        public decimal? VendorTotalCharge { get; set; }
        public bool? IsBadRecord { get; set; }
        public string? BadRecordMessage { get; set; }
        public decimal? VendorAffidavitCharge { get; set; }
        public bool? IsLetterImageProcessed { get; set; }
        public bool? IsInvoiceReceived { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public string? InvoiceImageId { get; set; }
        public bool? IsInvoiceImageProcessed { get; set; }
        public string? VendorPostalServiceRcvd { get; set; }
        public DateTime? MailSentOutDate { get; set; }
        public int? LetterDocId { get; set; }
        public int? InvoiceDocId { get; set; }
        public string? MasterInvoiceNumber { get; set; }
        public Guid? DocumentMailJobId { get; set; }
        public int ClientJobId { get; set; }
        public int CaseJobDefendantId { get; set; }
        public int DocumentTypeId { get; set; }
        public int MailServiceTypeLid { get; set; }
        public int MailVendorLid { get; set; }
        public int? SentByAssignmentId { get; set; }
        public int? EnvelopeDocumentId { get; set; }

        public virtual CaseJobDefendant CaseJobDefendant { get; set; } = null!;
        public virtual ClientJob ClientJob { get; set; } = null!;
        public virtual DocumentType DocumentType { get; set; } = null!;
        public virtual DocumentRepository? EnvelopeDocument { get; set; }
        public virtual ListItem MailServiceType { get; set; } = null!;
        public virtual ListItem MailVendorL { get; set; } = null!;
        public virtual ClientAssignment? SentByAssignment { get; set; }
    }
}
