using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class DocumentRepositoryConfiguration : IEntityTypeConfiguration<DocumentRepository>
{
    public void Configure(EntityTypeBuilder<DocumentRepository> entity)
    {
        entity.ToTable(TableNames.DocumentRepository);

        entity.HasKey(e => e.Id).HasName("PKDocumentRepository");

        entity.Property(e => e.Id).HasColumnName("DocumentRepositoryId");

        entity.HasIndex(e => e.BoundAssignmentId, "FKDocumentRepositoryBoundAssignmentId");

        entity.HasIndex(e => e.BoundCaseDefendantId, "FKDocumentRepositoryBoundCaseDefendantId");

        entity.HasIndex(e => e.BoundServiceDefendantId, "FKDocumentRepositoryBoundServiceDefendantId");

        entity.HasIndex(e => e.ClientJobId, "FKDocumentRepositoryClientJobId");

        entity.HasIndex(e => e.DeliveryMethodLid, "FKDocumentRepositoryDeliveryMethodLid");

        entity.HasIndex(e => e.DocumentTypeId, "FKDocumentRepositoryDocumentTypeId");

        entity.HasIndex(e => e.FromCheckListId, "FKDocumentRepositoryFromCheckListId");

        entity.HasIndex(e => e.LawPracticeJobId, "FKDocumentRepositoryLawPracticeJobId");

        entity.HasIndex(e => e.LastVersionDocumentId, "Ref117161");

        entity.HasIndex(e => e.NextVersionDocumentId, "Ref117162");

        entity.Property(e => e.CameFrom)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.DocumentName)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.FileLocationPath)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.FileLocationVirtualPath)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 2)");

        entity.Property(e => e.InvoiceNumber)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.IsCurrentVersion)
            .IsRequired()
            .HasColumnName("isCurrentVersion")
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.IsDeleted)
            .HasColumnName("isDeleted")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.Version).HasDefaultValueSql("((1))");

        entity.HasOne(d => d.BoundAssignment)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.BoundAssignmentId)
            .HasConstraintName("FKDocumentRepositoryBoundAssignmentId");

        entity.HasOne(d => d.BoundCaseDefendant)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.BoundCaseDefendantId)
            .HasConstraintName("FKDocumentRepositoryBoundCaseDefendantId");

        entity.HasOne(d => d.BoundServiceDefendant)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.BoundServiceDefendantId)
            .HasConstraintName("FKDocumentRepositoryBoundServiceDefendantId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentRepositoryClientJobId");

        entity.HasOne(d => d.DeliveryMethod)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.DeliveryMethodLid)
            .HasConstraintName("FKDocumentRepositoryDeliveryMethodLid");

        entity.HasOne(d => d.DocumentType)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.DocumentTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentRepositoryDocumentTypeId");

        entity.HasOne(d => d.FromCheckList)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.FromCheckListId)
            .HasConstraintName("FKDocumentRepositoryFromCheckListId");

        entity.HasOne(d => d.LastVersionDocument)
            .WithMany(p => p.InverseLastVersionDocument)
            .HasForeignKey(d => d.LastVersionDocumentId)
            .HasConstraintName("RefDocumentRepository161");

        entity.HasOne(d => d.LawPracticeJob)
            .WithMany(p => p.DocumentRepositories)
            .HasForeignKey(d => d.LawPracticeJobId)
            .HasConstraintName("FKDocumentRepositoryLawPracticeJobId");

        entity.HasOne(d => d.NextVersionDocument)
            .WithMany(p => p.InverseNextVersionDocument)
            .HasForeignKey(d => d.NextVersionDocumentId)
            .HasConstraintName("RefDocumentRepository162");
    }
}
