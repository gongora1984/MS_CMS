using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientJobLegalConfiguration : IEntityTypeConfiguration<ClientJobLegal>
{
    public void Configure(EntityTypeBuilder<ClientJobLegal> entity)
    {
        entity.ToTable(TableNames.ClientJobLegal);

        entity.HasKey(e => e.Id).HasName("PKClientJobLegal");

        entity.Property(e => e.Id).HasColumnName("ClientJobLegalId");

        entity.HasIndex(e => e.ClientJobId, "FKClientJobLegalClientJobId");

        entity.HasIndex(e => e.LegalDescFromLid, "FKClientJobLegalLegalDescFromLid");

        entity.HasIndex(e => e.VerifiedBy, "FKClientJobLegalVerifiedBy");

        entity.Property(e => e.LegalDescBook)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.LegalDescInstrument)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.LegalDescPage)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.LegalDescriptionCur)
            .HasMaxLength(4000)
        .IsUnicode(false);

        entity.Property(e => e.LegalDescriptionOrid)
            .HasMaxLength(4000)
            .IsUnicode(false);

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.ClientJobLegals)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientJobLegalClientJobId");

        entity.HasOne(d => d.LegalDescFrom)
            .WithMany(p => p.ClientJobLegals)
            .HasForeignKey(d => d.LegalDescFromLid)
            .HasConstraintName("FKClientJobLegalLegalDescFromLid");

        entity.HasOne(d => d.VerifiedByNavigation)
            .WithMany(p => p.ClientJobLegals)
            .HasForeignKey(d => d.VerifiedBy)
            .HasConstraintName("FKClientJobLegalVerifiedBy");
    }
}
