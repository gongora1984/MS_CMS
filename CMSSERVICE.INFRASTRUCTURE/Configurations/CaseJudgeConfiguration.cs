using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseJudgeConfiguration : IEntityTypeConfiguration<CaseJudge>
{
    public void Configure(EntityTypeBuilder<CaseJudge> entity)
    {
        entity.ToTable(TableNames.CaseJudge);

        entity.HasKey(e => e.Id).HasName("PKCaseJudge");

        entity.Property(e => e.Id).HasColumnName("CaseJudgeId");

        entity.HasIndex(e => e.CaseCourtId, "FKCaseJudgeCaseCourtId");

        entity.Property(e => e.Address1)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Fax)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.JudgeCourtName)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.JudgeName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.Location)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.Phone)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.Room)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.SpeacialInstructions1)
            .HasMaxLength(2000)
            .IsUnicode(false);

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseCourt)
            .WithMany(p => p.CaseJudges)
            .HasForeignKey(d => d.CaseCourtId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJudgeCaseCourtId");
    }
}
