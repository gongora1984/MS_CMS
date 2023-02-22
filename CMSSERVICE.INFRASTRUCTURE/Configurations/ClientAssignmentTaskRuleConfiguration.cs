using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentTaskRuleConfiguration : IEntityTypeConfiguration<ClientAssignmentTaskRule>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentTaskRule> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentTaskRule);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentTaskRule");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentTaskRuleId");

        entity.HasIndex(e => e.ClientAssignmentTaskCheckListId, "FKClientAssignmentTaskRuleClientAssignmentTaskCheckListId");

        entity.Property(e => e.Bkchapter)
            .HasMaxLength(500)
            .IsUnicode(false)
        .HasColumnName("BKChapter");

        entity.Property(e => e.Bkdistrict)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("BKDistrict");

        entity.Property(e => e.Bkstate)
            .HasMaxLength(500)
            .IsUnicode(false)
        .HasColumnName("BKState");

        entity.Property(e => e.Client)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.County)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.EffectiveEndDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.EffectiveStartDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.ReplevinType)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.RuleType)
            .HasMaxLength(1)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.State)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.HasOne(d => d.ClientAssignmentTaskCheckList)
            .WithMany(p => p.ClientAssignmentTaskRules)
            .HasForeignKey(d => d.ClientAssignmentTaskCheckListId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskRuleClientAssignmentTaskCheckListId");
    }
}
