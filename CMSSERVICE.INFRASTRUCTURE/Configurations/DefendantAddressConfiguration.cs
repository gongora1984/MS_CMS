using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class DefendantAddressConfiguration : IEntityTypeConfiguration<DefendantAddress>
{
    public void Configure(EntityTypeBuilder<DefendantAddress> entity)
    {
        entity.ToTable(TableNames.DefendantAddress);

        entity.HasKey(e => e.Id).HasName("PKDefendantAddress");

        entity.Property(e => e.Id).HasColumnName("DefendantAddressId");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKDefendantAddressCaseJobDefendantId");

        entity.Property(e => e.Address1)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.ServiceDate)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.DefendantAddresses)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDefendantAddressCaseJobDefendantId");
    }
}
