using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentTaskCheckListCrConfiguration : IEntityTypeConfiguration<ClientAssignmentTaskCheckListCr>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentTaskCheckListCr> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentTaskCheckListCr);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentTaskCheckListCr");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentTaskCheckListCrId");

        entity.Property(e => e.CompareType)
            .HasMaxLength(50)
            .IsUnicode(false)
        .HasDefaultValueSql("('==')");

        entity.Property(e => e.ConditionName)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.DropDownSql)
            .HasMaxLength(1500)
        .IsUnicode(false);

        entity.Property(e => e.IsSql)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.SelectValueSql)
            .HasMaxLength(500)
            .IsUnicode(false);
    }
}
