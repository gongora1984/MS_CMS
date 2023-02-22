using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal class LocalCounselConfiguration : IEntityTypeConfiguration<LocalCounsel>
{
    public void Configure(EntityTypeBuilder<LocalCounsel> entity)
    {
        entity.ToTable(TableNames.LocalCounsel);

        entity.HasKey(e => e.Id).HasName("PKLocalCounsel");

        entity.Property(e => e.Id).HasColumnName("LocalCounselId");

        entity.Property(e => e.IsLcactive)
            .IsRequired()
            .HasColumnName("IsLCActive")
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.Lcaddress1)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("LCAddress1");

        entity.Property(e => e.Lcaddress2)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("LCAddress2");

        entity.Property(e => e.LcbarNumber)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LCBarNumber");

        entity.Property(e => e.Lccity)
            .HasMaxLength(75)
            .IsUnicode(false)
        .HasColumnName("LCCity");

        entity.Property(e => e.LccompanyName)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("LCCompanyName");

        entity.Property(e => e.LccountyId).HasColumnName("LCCountyId");

        entity.Property(e => e.LcemailAddress)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("LCEmailAddress");

        entity.Property(e => e.LcfaxNumber)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasColumnName("LCFaxNumber");

        entity.Property(e => e.LcmoduleType)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("LCModuleType");

        entity.Property(e => e.Lcname)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("LCName");

        entity.Property(e => e.LcphoneNumber)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasColumnName("LCPhoneNumber");

        entity.Property(e => e.Lcstate)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("LCState");

        entity.Property(e => e.LctrackingNumber)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LCTrackingNumber");

        entity.Property(e => e.Lczip)
            .HasMaxLength(15)
            .IsUnicode(false)
        .HasColumnName("LCZip");

        entity.Property(e => e.LogoLocation)
            .HasMaxLength(500)
            .IsUnicode(false);
    }
}
