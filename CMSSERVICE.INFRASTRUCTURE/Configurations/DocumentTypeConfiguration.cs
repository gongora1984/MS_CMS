using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
{
    public void Configure(EntityTypeBuilder<DocumentType> entity)
    {
        entity.ToTable(TableNames.DocumentType);

        entity.HasKey(e => e.Id).HasName("PKDocumentType");

        entity.Property(e => e.Id).HasColumnName("DocumentTypeId");

        entity.HasIndex(e => e.ClientId, "FKDocumentTypeClientId");

        entity.HasIndex(e => e.DocumentCategoryLid, "FKDocumentTypeDocumentCategoryLid");

        entity.HasIndex(e => e.JobTypeId, "FKDocumentTypeJobTypeId");

        entity.Property(e => e.CanSendForService).HasColumnName("canSendForService");

        entity.Property(e => e.DocumentFileBase)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.DocumentTitle)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.EnvokesFileAssignment)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.HasVersioning)
            .IsRequired()
            .HasColumnName("hasVersioning")
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.IsClientView).HasDefaultValueSql("((1))");

        entity.Property(e => e.IsLawPracticeView).HasDefaultValueSql("((1))");

        entity.Property(e => e.IsLocalCounselView).HasDefaultValueSql("((1))");

        entity.Property(e => e.IsMergeDocument).HasColumnName("isMergeDocument");

        entity.Property(e => e.IsSecureDocument).HasColumnName("isSecureDocument");

        entity.Property(e => e.ProvestDocumentCode)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.SysDocumentCode)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("sysDocumentCode");

        entity.HasOne(d => d.Client)
            .WithMany(p => p.DocumentTypes)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentTypeClientId");

        entity.HasOne(d => d.DocumentCategory)
            .WithMany(p => p.DocumentTypes)
            .HasForeignKey(d => d.DocumentCategoryLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentTypeDocumentCategoryLid");

        entity.HasOne(d => d.JobType)
            .WithMany(p => p.DocumentTypes)
            .HasForeignKey(d => d.JobTypeId)
            .HasConstraintName("FKDocumentTypeJobTypeId");
    }
}
