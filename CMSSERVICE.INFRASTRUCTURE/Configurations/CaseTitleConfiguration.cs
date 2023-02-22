using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseTitleConfiguration : IEntityTypeConfiguration<CaseTitle>
{
    public void Configure(EntityTypeBuilder<CaseTitle> entity)
    {
        entity.ToTable(TableNames.CaseTitle);

        entity.HasKey(e => e.Id).HasName("PKCaseTitle");

        entity.Property(e => e.Id).HasColumnName("CaseTitleId");

        entity.HasIndex(e => e.CaseFclid, "FKCaseTitleCaseFCLId");

        entity.HasIndex(e => e.CaseTitleStatusLid, "FKCaseTitleCaseTitleStatusLid");

        entity.HasIndex(e => e.TitleUnderWriter, "FKCaseTitleCaseTitleUnderWriterId");

        entity.HasIndex(e => e.ClientInvestorTypeLid, "FKCaseTitleClientInvestorTypeLid");

        entity.HasIndex(e => e.CurrentTisdocId, "FKCaseTitleCurrentTISDocId");

        entity.HasIndex(e => e.MortgagePositionLid, "FKCaseTitleMortgagePositionLid");

        entity.HasIndex(e => e.TitleCompanyLid, "FKCaseTitleTitleCompanyLid");

        entity.HasIndex(e => e.TypeOfMortLid, "FKCaseTitleTypeOfMortLid");

        entity.HasIndex(e => e.UnderwriterLid, "FKCaseTitleUnderwriterLid");

        entity.Property(e => e.CaseFclid).HasColumnName("CaseFCLId");

        entity.Property(e => e.CurrentTisdocId).HasColumnName("CurrentTISDocId");

        entity.Property(e => e.DeedBook)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.DeedGrantee)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.DeedGrantor)
            .HasMaxLength(400)
        .IsUnicode(false);

        entity.Property(e => e.DeedIntrumentNo)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.DeedPage)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.DeedReRecBook)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.DeedReRecIntrumentNo)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.DeedReRecPage)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.DeedType)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.GenrlNotes)
            .HasMaxLength(8000)
            .IsUnicode(false);

        entity.Property(e => e.HasMersassignment).HasColumnName("HasMERSAssignment");

        entity.Property(e => e.IntegrationId1)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.IsMobilehome).HasColumnName("isMobilehome");

        entity.Property(e => e.IsMultiplex).HasColumnName("isMultiplex");

        entity.Property(e => e.IsTaxRoll).HasColumnName("isTaxRoll");

        entity.Property(e => e.LastTisgeneratedBy)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LastTISGeneratedBy");

        entity.Property(e => e.LastTisgeneratedDate).HasColumnName("LastTISGeneratedDate");

        entity.Property(e => e.LeinLegalDescriptionError).HasColumnType("text");

        entity.Property(e => e.MobileHomeDescription)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.MortLegalDescriptionError).HasColumnType("text");

        entity.Property(e => e.NeedsReformationReason)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.Njblock)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("NJBlock");

        entity.Property(e => e.Njlot)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("NJLot");

        entity.Property(e => e.Njqualifier)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("NJQualifier");

        entity.Property(e => e.NonForeclosableLiensDetail)
            .HasMaxLength(4000)
            .IsUnicode(false);

        entity.Property(e => e.NumberOfUnits).HasDefaultValueSql("((1))");

        entity.Property(e => e.OpenLpDetail)
            .HasMaxLength(4000)
            .IsUnicode(false);

        entity.Property(e => e.OrderType)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.ProductType)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.PropelId)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("PropelID");

        entity.Property(e => e.PropertyDistrictLid).HasColumnName("PropertyDistrictLID");

        entity.Property(e => e.ServiceType)
            .HasMaxLength(20)
            .IsUnicode(false);

        entity.Property(e => e.SuperiorLiens)
            .HasMaxLength(4000)
            .IsUnicode(false);

        entity.Property(e => e.TaxId)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.TitleClaimBody)
            .HasMaxLength(2500)
            .IsUnicode(false);

        entity.Property(e => e.TitleClaimPolicyNum)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.TitleClaimsDetail)
            .HasMaxLength(4000)
            .IsUnicode(false);

        entity.Property(e => e.TitleLegalDescription).HasColumnType("text");

        entity.Property(e => e.TitleMortBook)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.TitleMortInstrumentNum)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.TitleMortPage)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.TitleMortgagee)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.TitleMortgagor)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.TitleTypeOfMortgage)
            .HasMaxLength(1)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.WhoSignedMortgage)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.WhoSignedNote)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseFcl)
            .WithMany(p => p.CaseTitles)
            .HasForeignKey(d => d.CaseFclid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseTitleCaseFCLId");

        entity.HasOne(d => d.CaseTitleStatus)
            .WithMany(p => p.CaseTitleCaseTitleStatusLs)
            .HasForeignKey(d => d.CaseTitleStatusLid)
            .HasConstraintName("FKCaseTitleCaseTitleStatusLid");

        entity.HasOne(d => d.ClientInvestorType)
            .WithMany(p => p.CaseTitleClientInvestorTypeLs)
            .HasForeignKey(d => d.ClientInvestorTypeLid)
            .HasConstraintName("FKCaseTitleClientInvestorTypeLid");

        entity.HasOne(d => d.CurrentTisdoc)
            .WithMany(p => p.CaseTitles)
            .HasForeignKey(d => d.CurrentTisdocId)
            .HasConstraintName("FKCaseTitleCurrentTISDocId");

        entity.HasOne(d => d.MortgagePosition)
            .WithMany(p => p.CaseTitleMortgagePositionLs)
            .HasForeignKey(d => d.MortgagePositionLid)
            .HasConstraintName("FKCaseTitleMortgagePositionLid");

        entity.HasOne(d => d.TitleCompany)
            .WithMany(p => p.CaseTitleTitleCompanyLs)
            .HasForeignKey(d => d.TitleCompanyLid)
            .HasConstraintName("FKCaseTitleTitleCompanyLid");

        entity.HasOne(d => d.TitleUnderWriterNavigation)
            .WithMany(p => p.CaseTitles)
            .HasForeignKey(d => d.TitleUnderWriter)
            .HasConstraintName("FKCaseTitleCaseTitleUnderWriterId");

        entity.HasOne(d => d.TypeOfMort)
            .WithMany(p => p.CaseTitleTypeOfMortLs)
            .HasForeignKey(d => d.TypeOfMortLid)
            .HasConstraintName("FKCaseTitleTypeOfMortLid");

        entity.HasOne(d => d.Underwriter)
            .WithMany(p => p.CaseTitleUnderwriterLs)
            .HasForeignKey(d => d.UnderwriterLid)
            .HasConstraintName("FKCaseTitleUnderwriterLid");
    }
}
