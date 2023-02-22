using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseJobDefendantAttyConfiguration : IEntityTypeConfiguration<CaseJobDefendantAtty>
{
    public void Configure(EntityTypeBuilder<CaseJobDefendantAtty> entity)
    {
        entity.ToTable(TableNames.CaseJobDefendantAtty);

        entity.HasKey(e => e.Id).HasName("PKCaseJobDefendantAtty");

        entity.Property(e => e.Id).HasColumnName("CaseJobDefendantAttyId");

        entity.Property(e => e.Address1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.AttorneyName)
            .HasMaxLength(300)
        .IsUnicode(false);

        entity.Property(e => e.AttyBarNumber)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.BusPhoneNum)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.EmailAddress)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.EmailAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

        entity.Property(e => e.LawPracticeName)
            .HasMaxLength(300)
            .IsUnicode(false);

        entity.Property(e => e.LoginDetailsId).HasColumnName("LoginDetailsID");

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);
    }
}
