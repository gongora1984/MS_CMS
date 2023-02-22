using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseJobDefendantServiceConfiguration : IEntityTypeConfiguration<CaseJobDefendantService>
{
    public void Configure(EntityTypeBuilder<CaseJobDefendantService> entity)
    {
        entity.ToTable(TableNames.CaseJobDefendantService);

        entity.HasKey(e => e.Id).HasName("PKCaseJobDefendantService");

        entity.Property(e => e.Id).HasColumnName("CaseJobDefendantServiceId");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKCaseJobDefendantServiceCaseJobDefendantId");

        entity.HasIndex(e => e.ClientAssignmentId, "FKCaseJobDefendantServiceClientAssignmentId");

        entity.HasIndex(e => e.DocumentTypeId, "FKCaseJobDefendantServiceDocumentTypeId");

        entity.HasIndex(e => e.ServiceStatusLid, "FKCaseJobDefendantServiceServiceStatusLid");

        entity.HasIndex(e => e.ServiceTypeLid, "FKCaseJobDefendantServiceServiceTypeLid");

        entity.Property(e => e.CurrentWorkFlowId).HasDefaultValueSql("((-1))");

        entity.Property(e => e.DefendantAlius)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.DefendantName)
            .HasMaxLength(500)
        .IsUnicode(false);

        entity.Property(e => e.DefendantWorkFlowKey)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.IsMobileHome).HasColumnName("isMobileHome");

        entity.Property(e => e.IsMultiPlex).HasColumnName("isMultiPlex");

        entity.Property(e => e.LpdefendantId)
            .HasColumnName("LPDefendantId")
            .HasDefaultValueSql("((-1))");

        entity.Property(e => e.Lpkey1)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LPKey1");

        entity.Property(e => e.Notes)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.ServiceAddressId).HasDefaultValueSql("((-1))");

        entity.Property(e => e.ServiceTta).HasColumnName("ServiceTTA");

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.CaseJobDefendantServices)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantServiceCaseJobDefendantId");

        entity.HasOne(d => d.ClientAssignment)
            .WithMany(p => p.CaseJobDefendantServices)
            .HasForeignKey(d => d.ClientAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantServiceClientAssignmentId");

        entity.HasOne(d => d.DocumentType)
            .WithMany(p => p.CaseJobDefendantServices)
            .HasForeignKey(d => d.DocumentTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantServiceDocumentTypeId");

        entity.HasOne(d => d.ServiceStatus)
            .WithMany(p => p.CaseJobDefendantServiceServiceStatusLs)
            .HasForeignKey(d => d.ServiceStatusLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantServiceServiceStatusLid");

        entity.HasOne(d => d.ServiceType)
            .WithMany(p => p.CaseJobDefendantServiceServiceTypeLs)
            .HasForeignKey(d => d.ServiceTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantServiceServiceTypeLid");
    }
}
