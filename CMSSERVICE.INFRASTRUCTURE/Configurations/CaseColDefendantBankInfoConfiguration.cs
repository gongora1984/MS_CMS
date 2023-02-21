using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseColDefendantBankInfoConfiguration : IEntityTypeConfiguration<CaseColDefendantBankInfo>
{
    public void Configure(EntityTypeBuilder<CaseColDefendantBankInfo> entity)
    {
        entity.ToTable(TableNames.CaseColDefendantBankInfo);

        entity.HasKey(e => e.Id).HasName("PKCaseColDefendantBankInfo");

        entity.Property(e => e.Id).HasColumnName("CaseColDefendantBankInfoId");

        entity.HasIndex(e => e.AccountTypeLid, "FKCaseCOLDefendantBankInfoAccountTypeLId");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKCaseCOLDefendantBankInfoCaseJobDefendantId");

        entity.Property(e => e.AccountNumber)
            .HasMaxLength(256)
        .IsUnicode(false);

        entity.Property(e => e.AccountNumberLast4)
            .HasMaxLength(10)
        .IsFixedLength();

        entity.Property(e => e.AccountTypeLid).HasColumnName("AccountTypeLId");

        entity.Property(e => e.Bank)
            .HasMaxLength(256)
        .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.NameOnAccount)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.RountingNumber)
            .HasMaxLength(256)
            .IsUnicode(false);

        entity.Property(e => e.State)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.Street)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.TransactionType)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.Property(e => e.ZipCode)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.HasOne(d => d.AccountType)
            .WithMany(p => p.CaseColDefendantBankInfos)
            .HasForeignKey(d => d.AccountTypeLid)
            .HasConstraintName("FKCaseCOLDefendantBankInfoAccountTypeLId");

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.CaseColDefendantBankInfos)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCOLDefendantBankInfoCaseJobDefendantId");
    }
}
