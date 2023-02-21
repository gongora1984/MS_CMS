using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseColDefendantCardInfoConfiguration : IEntityTypeConfiguration<CaseColDefendantCardInfo>
{
    public void Configure(EntityTypeBuilder<CaseColDefendantCardInfo> entity)
    {
        entity.ToTable(TableNames.CaseColDefendantCardInfo);

        entity.HasKey(e => e.Id).HasName("PKCaseColDefendantCardInfo");

        entity.Property(e => e.Id).HasColumnName("CaseColDefendantCardInfoId");

        entity.HasIndex(e => e.AccountTypeLid, "FKCaseCOLDefendantCardInfoAccountTypeLId");

        entity.HasIndex(e => e.CaseJobDefendantId, "FKCaseCOLDefendantCardInfoCaseJobDefendantId");

        entity.Property(e => e.AccountTypeLid).HasColumnName("AccountTypeLId");

        entity.Property(e => e.Ccaddress)
            .HasMaxLength(200)
            .IsUnicode(false)
        .HasColumnName("CCAddress");

        entity.Property(e => e.Cccity)
            .HasMaxLength(50)
            .IsUnicode(false)
        .HasColumnName("CCCity");

        entity.Property(e => e.Cccvv)
            .HasMaxLength(256)
            .IsUnicode(false)
        .HasColumnName("CCcvv");

        entity.Property(e => e.CcexpirationMm)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("CCExpirationMM");

        entity.Property(e => e.CcexpirationYy)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("CCExpirationYY");

        entity.Property(e => e.Ccname)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("CCName");

        entity.Property(e => e.Ccnumber)
            .HasMaxLength(256)
            .IsUnicode(false)
            .HasColumnName("CCNumber");

        entity.Property(e => e.CcnumberLast4)
            .HasMaxLength(4)
            .IsUnicode(false)
            .HasColumnName("CCNumberLast4");

        entity.Property(e => e.Ccstate)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("CCState");

        entity.Property(e => e.Cctype)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("CCType");

        entity.Property(e => e.CczipCode)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("CCZipCode");

        entity.Property(e => e.NameOnAccount)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.TransactionType)
            .HasMaxLength(10)
            .IsUnicode(false);

        entity.HasOne(d => d.AccountType)
            .WithMany(p => p.CaseColDefendantCardInfos)
            .HasForeignKey(d => d.AccountTypeLid)
            .HasConstraintName("FKCaseCOLDefendantCardInfoAccountTypeLId");

        entity.HasOne(d => d.CaseJobDefendant)
            .WithMany(p => p.CaseColDefendantCardInfos)
            .HasForeignKey(d => d.CaseJobDefendantId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCOLDefendantCardInfoCaseJobDefendantId");
    }
}
