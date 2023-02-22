using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseMasterConfiguration : IEntityTypeConfiguration<CaseMaster>
{
    public void Configure(EntityTypeBuilder<CaseMaster> entity)
    {
        entity.ToTable(TableNames.CaseMaster);

        entity.HasKey(e => e.Id).HasName("PKCaseMaster");

        entity.Property(e => e.Id).HasColumnName("CaseId");

        entity.HasIndex(e => e.ClientId, "FKCaseClientId");

        entity.HasIndex(e => e.CaseCountyId, "FKCaseMasterCaseCountyId");

        entity.Property(e => e.CaseReferance)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.ClientInternalRef)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.ClientReferance)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.JobRecipientName)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.RecipientAdd1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.RecipientAdd2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.RecipientCity)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.RecipientState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.RecipientZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseCounty)
            .WithMany(p => p.CaseMasters)
            .HasForeignKey(d => d.CaseCountyId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseMasterCaseCountyId");

        entity.HasOne(d => d.Client)
            .WithMany(p => p.CaseMasters)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseClientId");
    }
}
