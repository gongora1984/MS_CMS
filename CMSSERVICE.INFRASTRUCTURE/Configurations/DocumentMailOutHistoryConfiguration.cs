using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class DocumentMailOutHistoryConfiguration : IEntityTypeConfiguration<DocumentMailOutHistory>
{
    public void Configure(EntityTypeBuilder<DocumentMailOutHistory> entity)
    {
        entity.ToTable(TableNames.DocumentMailOutHistory);

        entity.HasKey(e => e.Id).HasName("PKDocumentMailOutHistory");

        entity.Property(e => e.Id).HasColumnName("DocumentMailOutHistoryId");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKDocumentMailOutHistoryCaseJobDefendantId");

        entity.HasIndex(e => e.ClientJobId, "FKDocumentMailOutHistoryClientJobId");

        entity.HasIndex(e => e.DocumentTypeId, "FKDocumentMailOutHistoryDocumentTypeId");

        entity.HasIndex(e => e.MailServiceTypeLid, "FKDocumentMailOutHistoryMailServiceTypeLid");

        entity.HasIndex(e => e.MailVendorLid, "FKDocumentMailOutHistoryMailVendorLid");

        entity.HasIndex(e => e.SentByAssignmentId, "FKDocumentMailOutHistorySentByAssignmentId");

        entity.HasIndex(e => e.EnvelopeDocumentId, "FKEnvelopeDocumentId");

        entity.Property(e => e.Address1)
            .HasMaxLength(300)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(300)
        .IsUnicode(false);

        entity.Property(e => e.BadRecordMessage)
            .HasMaxLength(5000)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.InvoiceDocId).HasColumnName("InvoiceDocID");

        entity.Property(e => e.InvoiceImageId)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("InvoiceImageID");

        entity.Property(e => e.InvoiceNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.IsInvoiceImageProcessed).HasDefaultValueSql("((0))");

        entity.Property(e => e.IsInvoiceReceived).HasDefaultValueSql("((0))");

        entity.Property(e => e.IsLetterImageProcessed).HasDefaultValueSql("((0))");

        entity.Property(e => e.LetterDocId).HasColumnName("LetterDocID");

        entity.Property(e => e.MasterInvoiceNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.ReceiptId)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ReceiptID");

        entity.Property(e => e.RecipientName)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.SentOutDate).HasDefaultValueSql("(getdate())");

        entity.Property(e => e.State)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.TrackingLastEntry)
            .HasMaxLength(2000)
            .IsUnicode(false);

        entity.Property(e => e.TrackingNumber)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.VenderPostageAmount).HasColumnType("decimal(16, 3)");

        entity.Property(e => e.VendorAdditionalCharge).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.VendorAffidavitCharge).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.VendorPostalServiceRcvd)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.VendorPostalServiceSent)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.VendorServiceCharge).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.VendorTotalCharge).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.Zip)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.DocumentMailOutHistories)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentMailOutHistoryCaseJobDefendantId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.DocumentMailOutHistories)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentMailOutHistoryClientJobId");

        entity.HasOne(d => d.DocumentType)
            .WithMany(p => p.DocumentMailOutHistories)
            .HasForeignKey(d => d.DocumentTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentMailOutHistoryDocumentTypeId");

        entity.HasOne(d => d.EnvelopeDocument)
            .WithMany(p => p.DocumentMailOutHistories)
            .HasForeignKey(d => d.EnvelopeDocumentId)
            .HasConstraintName("FKEnvelopeDocumentId");

        entity.HasOne(d => d.MailServiceType)
            .WithMany(p => p.DocumentMailOutHistoryMailServiceTypeLs)
            .HasForeignKey(d => d.MailServiceTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentMailOutHistoryMailServiceTypeLid");

        entity.HasOne(d => d.MailVendorL)
            .WithMany(p => p.DocumentMailOutHistoryMailVendorLs)
            .HasForeignKey(d => d.MailVendorLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentMailOutHistoryMailVendorLid");

        entity.HasOne(d => d.SentByAssignment)
            .WithMany(p => p.DocumentMailOutHistories)
            .HasForeignKey(d => d.SentByAssignmentId)
            .HasConstraintName("FKDocumentMailOutHistorySentByAssignmentId");
    }
}
