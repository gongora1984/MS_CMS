using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations
{
    internal sealed class CaseSubpoenaOrderInfoConfiguration : IEntityTypeConfiguration<CaseSubpoenaOrderInfo>
    {
        public void Configure(EntityTypeBuilder<CaseSubpoenaOrderInfo> entity)
        {
            entity.ToTable(TableNames.CaseSubpoenaOrderInfo);

            entity.HasKey(e => e.Id).HasName("PKCaseSubpoenaOrderInfo");

            entity.Property(e => e.Id).HasColumnName("CaseSubpoenaOrderInfoId");

            entity.HasIndex(e => e.CaseSubpoenaId, "FKCaseSubpoenaOrderInfoCaseSubpoenaId");

            entity.HasIndex(e => e.InformationRequestedLid, "FKCaseSubpoenaOrderInfoInformationRequestedLid");

            entity.HasIndex(e => e.InformationRequestedStatusLid, "FKInformationRequestedStatusLid");

            entity.HasIndex(e => e.IsOrderAskingForRecordsLid, "FKIsOrderAskingForRecordsLid");

            entity.Property(e => e.AdditionalComments)
                .HasMaxLength(250)
            .IsUnicode(false);

            entity.Property(e => e.InformationRequestedComment)
                .HasMaxLength(250)
            .IsUnicode(false);

            entity.Property(e => e.InformationRequestedStatusComment)
                .HasMaxLength(250)
            .IsUnicode(false);

            entity.Property(e => e.IntegrationId)
                .HasMaxLength(50)
            .IsUnicode(false);

            entity.HasOne(d => d.CaseSubpoena)
                .WithMany(p => p.CaseSubpoenaOrderInfos)
                .HasForeignKey(d => d.CaseSubpoenaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCaseSubpoenaOrderInfoCaseSubpoenaId");

            entity.HasOne(d => d.InformationRequested)
                .WithMany(p => p.CaseSubpoenaOrderInfoInformationRequestedLs)
                .HasForeignKey(d => d.InformationRequestedLid)
                .HasConstraintName("FKCaseSubpoenaOrderInfoInformationRequestedLid");

            entity.HasOne(d => d.InformationRequestedStatus)
                .WithMany(p => p.CaseSubpoenaOrderInfoInformationRequestedStatusLs)
                .HasForeignKey(d => d.InformationRequestedStatusLid)
                .HasConstraintName("FKInformationRequestedStatusLid");

            entity.HasOne(d => d.IsOrderAskingForRecords)
                .WithMany(p => p.CaseSubpoenaOrderInfoIsOrderAskingForRecordsLs)
                .HasForeignKey(d => d.IsOrderAskingForRecordsLid)
                .HasConstraintName("FKIsOrderAskingForRecordsLid");
        }
    }
}
