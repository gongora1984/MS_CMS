using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseColConfiguration : IEntityTypeConfiguration<CaseCol>
{
    public void Configure(EntityTypeBuilder<CaseCol> entity)
    {
        entity.ToTable(TableNames.CaseCol);

        entity.HasKey(e => e.Id).HasName("PKCaseCol");

        entity.Property(e => e.Id).HasColumnName("CaseColId");

        entity.HasIndex(e => e.ClientJobId, "FKCaseCOLClientJobId");

        entity.HasIndex(e => e.CaseColcloseReasonLid, "FKCaseCOLCloseReasonLid");

        entity.HasIndex(e => e.LastAssignmentId, "FKCaseCOLLastAssignmentId");

        entity.HasIndex(e => e.NextAssignmentId, "FKCaseCOLNextAssignmentId");

        entity.HasIndex(e => e.CaseColstatusLid, "FKCaseCOLStatusLid");

        entity.Property(e => e.BeginingPrincipal).HasColumnType("decimal(16, 2)");

        entity.Property(e => e.CaseColcloseReasonLid).HasColumnName("CaseCOLCloseReasonLid");

        entity.Property(e => e.CaseColstatusLid).HasColumnName("CaseCOLStatusLid");

        entity.Property(e => e.ClaimTypeDescription)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.ClientAttyName)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.ClientCaseNumber)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.CompanyName)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.CourtCaseNumber)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DefendantCap)
            .HasMaxLength(600)
            .IsUnicode(false);

        entity.Property(e => e.InterestRate).HasColumnType("decimal(16, 2)");

        entity.Property(e => e.InvestorTypeDesc)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.LastPaymentAmount).HasColumnType("decimal(16, 2)");

        entity.Property(e => e.LoanNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PlaintiffCap)
            .HasMaxLength(600)
            .IsUnicode(false);

        entity.Property(e => e.PropertyAddress1)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.PropertyAddress2)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.PropertyCity)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PropertyState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.PropertyZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Referance)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.Soldate).HasColumnName("SOLDate");

        entity.HasOne(d => d.CaseColCloseReason)
            .WithMany(p => p.CaseColCaseColcloseReasonLs)
            .HasForeignKey(d => d.CaseColcloseReasonLid)
            .HasConstraintName("FKCaseCOLCloseReasonLid");

        entity.HasOne(d => d.CaseColStatus)
            .WithMany(p => p.CaseColCaseColstatusLs)
            .HasForeignKey(d => d.CaseColstatusLid)
            .HasConstraintName("FKCaseCOLStatusLid");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseCols)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCOLClientJobId");

        entity.HasOne(d => d.LastAssignment)
            .WithMany(p => p.CaseColLastAssignments)
            .HasForeignKey(d => d.LastAssignmentId)
            .HasConstraintName("FKCaseCOLLastAssignmentId");

        entity.HasOne(d => d.NextAssignment)
            .WithMany(p => p.CaseColNextAssignments)
            .HasForeignKey(d => d.NextAssignmentId)
            .HasConstraintName("FKCaseCOLNextAssignmentId");
    }
}
