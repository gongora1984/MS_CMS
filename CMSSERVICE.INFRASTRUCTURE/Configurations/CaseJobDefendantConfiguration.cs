using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal class CaseJobDefendantConfiguration : IEntityTypeConfiguration<CaseJobDefendant>
{
    public void Configure(EntityTypeBuilder<CaseJobDefendant> entity)
    {
        entity.ToTable(TableNames.CaseJobDefendant);

        entity.HasKey(e => e.Id).HasName("PKCaseJobDefendant");

        entity.Property(e => e.Id).HasColumnName("CaseJobDefendantId");

        entity.HasIndex(e => e.CaseJobDefendantAttyId, "FKCaseJobDefendantAttyId");

        entity.HasIndex(e => e.ClientJobId, "FKCaseJobDefendantClientJobId");

        entity.HasIndex(e => e.PacerDocumentId, "FKCaseJobDefendantPacerDocumentId");

        entity.HasIndex(e => e.PartyTypeLid, "FKCaseJobDefendantPartyTypeLid");

        entity.HasIndex(e => e.RequestorOrganizationLid, "FKCaseJobDefendantRequestorOrganizationLid");

        entity.HasIndex(e => e.ServiceTypeLid, "FKCaseJobDefendantServiceTypeLid");

        entity.Property(e => e.Active)
            .IsRequired()
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.Address1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.BusinessPhoneNum)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.CaseNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.CurrentWorkFlowId)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.DefendantAlius)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.DefendantDob).HasColumnName("DefendantDOB");

        entity.Property(e => e.DefendantDod).HasColumnName("DefendantDOD");

        entity.Property(e => e.DefendantName)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.DefendantSsn)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("DefendantSSN");

        entity.Property(e => e.DefendantSsn4)
            .HasMaxLength(4)
            .IsUnicode(false)
            .HasColumnName("DefendantSSN4");

        entity.Property(e => e.EmailAddress)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.FaxNumber)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationId)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.OrganizationName)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.PacerSearchResults)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.PartyTypeName)
            .HasMaxLength(300)
            .IsUnicode(false);

        entity.Property(e => e.PhoneNumber)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.SameasPropertyAddress).HasDefaultValueSql("((0))");

        entity.Property(e => e.ServiceAddress1)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.ServiceAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.ServiceCity)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.ServiceState)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.ServiceZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseJobDefendantAtty)
            .WithMany(p => p.CaseJobDefendants)
            .HasForeignKey(d => d.CaseJobDefendantAttyId)
            .HasConstraintName("FKCaseJobDefendantAttyId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseJobDefendants)
            .HasForeignKey(d => d.ClientJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantClientJobId");

        entity.HasOne(d => d.PacerDocument)
            .WithMany(p => p.CaseJobDefendants)
            .HasForeignKey(d => d.PacerDocumentId)
            .HasConstraintName("FKCaseJobDefendantPacerDocumentId");

        entity.HasOne(d => d.PartyType)
            .WithMany(p => p.CaseJobDefendantPartyTypeLs)
            .HasForeignKey(d => d.PartyTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseJobDefendantPartyTypeLid");

        entity.HasOne(d => d.RequestorOrganization)
            .WithMany(p => p.CaseJobDefendantRequestorOrganizationLs)
            .HasForeignKey(d => d.RequestorOrganizationLid)
            .HasConstraintName("FKCaseJobDefendantRequestorOrganizationLid");

        entity.HasOne(d => d.ServiceType)
            .WithMany(p => p.CaseJobDefendantServiceTypeLs)
            .HasForeignKey(d => d.ServiceTypeLid)
            .HasConstraintName("FKCaseJobDefendantServiceTypeLid");
    }
}
