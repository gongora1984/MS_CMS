using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleAssignmentItemConfiguration : IEntityTypeConfiguration<CaseTitleAssignmentItem>
{
    public void Configure(EntityTypeBuilder<CaseTitleAssignmentItem> entity)
    {
        entity.ToTable(TableNames.CaseTitleAssignmentItem);

        entity.HasKey(e => e.Id).HasName("PKCaseTitleAssignmentItem");

        entity.Property(e => e.Id).HasColumnName("CaseTitleAssignmentItemId");

        entity.HasIndex(e => e.CaseTitleAssignmentId, "FKCaseTitleAssignmentItemCaseTitleAssignmentId");

        entity.Property(e => e.StateId)
            .HasMaxLength(10)
        .IsUnicode(false);

        entity.Property(e => e.TitleAssignmentCost).HasColumnType("decimal(10, 2)");

        entity.Property(e => e.TitleAssignmentDescription)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.TitleAssignmentFee).HasColumnType("decimal(10, 2)");

        entity.HasOne(d => d.CaseTitleAssignment)
            .WithMany(p => p.CaseTitleAssignmentItems)
            .HasForeignKey(d => d.CaseTitleAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleAssignmentItemCaseTitleAssignmentId");
    }
}
