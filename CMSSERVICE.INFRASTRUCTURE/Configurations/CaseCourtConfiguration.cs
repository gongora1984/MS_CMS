using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseCourtConfiguration : IEntityTypeConfiguration<CaseCourt>
{
    public void Configure(EntityTypeBuilder<CaseCourt> entity)
    {
        entity.ToTable(TableNames.CaseCourt);

        entity.HasKey(e => e.Id).HasName("PKCaseCourt");

        entity.Property(e => e.Id).HasColumnName("CaseCourtId");

        entity.HasIndex(e => e.CaseCountyId, "FKCaseCourtCaseCountyId");

        entity.HasIndex(e => e.CaseDistrictId, "FKCaseCourtCaseDistrictId");

        entity.HasIndex(e => e.CourtTypeLid, "FKCaseCourtCourtType");

        entity.Property(e => e.Address1)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.ClerkContact)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.CountOfficalName)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.CourtCurcit)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CourtName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CourtNotes)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.Email)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.Fax)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.Phone)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.PstcurcitCode)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("PSTCurcitCode");

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Website)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseCounty)
            .WithMany(p => p.CaseCourts)
            .HasForeignKey(d => d.CaseCountyId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCourtCaseCountyId");

        entity.HasOne(d => d.CaseDistrict)
            .WithMany(p => p.CaseCourts)
            .HasForeignKey(d => d.CaseDistrictId)
            .HasConstraintName("FKCaseCourtCaseDistrictId");

        entity.HasOne(d => d.CourtType)
            .WithMany(p => p.CaseCourts)
            .HasForeignKey(d => d.CourtTypeLid)
            .HasConstraintName("FKCaseCourtCourtType");
    }
}
