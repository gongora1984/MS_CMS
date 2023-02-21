using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseColTransactionConfiguration : IEntityTypeConfiguration<CaseColTransaction>
{
    public void Configure(EntityTypeBuilder<CaseColTransaction> entity)
    {
        entity.ToTable(TableNames.CaseColTransaction);

        entity.HasKey(e => e.Id).HasName("PKCaseColTransaction");

        entity.Property(e => e.Id).HasColumnName("CaseColTransactionId");

        entity.HasIndex(e => e.CaseColid, "FKCaseCOLTransactionCaseCOLId");

        entity.Property(e => e.AppCost)
            .HasColumnType("decimal(16, 2)")
        .HasColumnName("appCost");

        entity.Property(e => e.AppFees)
            .HasColumnType("decimal(16, 2)")
        .HasColumnName("appFees");

        entity.Property(e => e.AppInterest)
            .HasColumnType("decimal(16, 2)")
            .HasColumnName("appInterest");

        entity.Property(e => e.AppOther)
            .HasColumnType("decimal(16, 2)")
            .HasColumnName("appOther");

        entity.Property(e => e.AppPrince)
            .HasColumnType("decimal(16, 2)")
            .HasColumnName("appPrince");

        entity.Property(e => e.Balance).HasColumnType("decimal(16, 2)");

        entity.Property(e => e.CaseColid).HasColumnName("CaseCOLId");

        entity.Property(e => e.Tally)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.TallyCode)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.TransactionAmount).HasColumnType("decimal(16, 2)");

        entity.Property(e => e.TransactionDescription)
            .HasMaxLength(250)
        .IsUnicode(false);

        entity.Property(e => e.TransactionType)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.HasOne(d => d.CaseCol)
            .WithMany(p => p.CaseColTransactions)
            .HasForeignKey(d => d.CaseColid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCOLTransactionCaseCOLId");
    }
}
