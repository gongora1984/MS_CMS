using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseAutoBuyerInfoConfiguration : IEntityTypeConfiguration<CaseAutoBuyerInfo>
{
    public void Configure(EntityTypeBuilder<CaseAutoBuyerInfo> entity)
    {
        entity.ToTable(TableNames.CaseAutoBuyerInfo);

        entity.HasKey(e => e.Id).HasName("PKCaseAutoBuyerInfo");

        entity.Property(e => e.Id).HasColumnName("CaseAutoBuyerInfoId");

        entity.HasIndex(e => e.CaseAutoId, "FKCaseAutoBuyerInfoCaseAutoId");

        entity.Property(e => e.AltPhoneNum)
            .HasMaxLength(20)
        .IsUnicode(false);

        entity.Property(e => e.AssignedAgentLid).HasColumnName("AssignedAgentLID");

        entity.Property(e => e.BackgroundCheckLid).HasColumnName("BackgroundCheckLID");

        entity.Property(e => e.BuyerName)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.BuyingActionLid).HasColumnName("BuyingActionLID");

        entity.Property(e => e.BuyingStatusLid).HasColumnName("BuyingStatusLID");

        entity.Property(e => e.CreatedOn)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.DlexpiryDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("DLExpiryDate")
        .IsFixedLength();

        entity.Property(e => e.DriverLicenseDocRepId).HasColumnName("DriverLicenseDocRepID");

        entity.Property(e => e.EmailAddress)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.FollowUpComment).IsUnicode(false);

        entity.Property(e => e.FollowUpDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.OnlinePlacementLid).HasColumnName("OnlinePlacementLID");

        entity.Property(e => e.PhoneNumber)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.TestDriveDate)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.TestDriveResultsLid).HasColumnName("TestDriveResultsLID");

        entity.Property(e => e.UpdatedOn)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.HasOne(d => d.CaseAuto)
            .WithMany(p => p.CaseAutoBuyerInfos)
            .HasForeignKey(d => d.CaseAutoId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseAutoBuyerInfoCaseAutoId");
    }
}
