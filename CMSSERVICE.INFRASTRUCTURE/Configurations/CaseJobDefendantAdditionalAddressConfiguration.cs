using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseJobDefendantAdditionalAddressConfiguration : IEntityTypeConfiguration<CaseJobDefendantAdditionalAddress>
{
    public void Configure(EntityTypeBuilder<CaseJobDefendantAdditionalAddress> entity)
    {
        entity.ToTable(TableNames.CaseJobDefendantAdditionalAddress);

        entity.HasKey(e => e.Id).HasName("PKCaseJobDefendantAdditionalAddress");

        entity.Property(e => e.Id).HasColumnName("CaseJobDefendantAdditionalAddressId");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKCaseJobDefendantAdditionalAddressCaseJobDefendantId");

        entity.Property(e => e.Active)
            .IsRequired()
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.Address1)
            .HasMaxLength(1500)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.StateId)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.CaseJobDefendantAdditionalAddresses)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantAdditionalAddressCaseJobDefendantId");
    }
}
