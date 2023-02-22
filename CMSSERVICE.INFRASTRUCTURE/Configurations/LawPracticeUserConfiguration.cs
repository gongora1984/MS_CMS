using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LawPracticeUserConfiguration : IEntityTypeConfiguration<LawPracticeUser>
{
    public void Configure(EntityTypeBuilder<LawPracticeUser> entity)
    {
        entity.ToTable(TableNames.LawPracticeUser);

        entity.HasKey(e => e.Id).HasName("PKLawPracticeUser");

        entity.Property(e => e.Id).HasColumnName("LawPracticeUserId");

        entity.HasIndex(e => e.ClientId, "FKLawPracticeUserClientId");

        entity.HasIndex(e => e.LawPracticeId, "FKLawPracticeUserLawPracticeId");

        entity.HasIndex(e => e.LoginDetailId, "FKLawPracticeUserLoginDetailId");

        entity.Property(e => e.ActionTypeCode)
            .HasMaxLength(1)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.AttyBarNumber)
            .HasMaxLength(25)
        .IsUnicode(false);

        entity.Property(e => e.AttyLastPinCreated)
            .HasMaxLength(10)
            .IsUnicode(false)
        .IsFixedLength();

        entity.Property(e => e.AttyPinNumer)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.AttySignImagePath)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.Enabled).HasColumnName("enabled");

        entity.Property(e => e.HourlyConntractRate).HasColumnType("money");

        entity.Property(e => e.IsLocalCounsel).HasColumnName("isLocalCounsel");

        entity.Property(e => e.IsRemote).HasColumnName("isRemote");

        entity.Property(e => e.LawPracticeUserName)
            .HasMaxLength(300)
            .IsUnicode(false);

        entity.Property(e => e.Smsemail)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("SMSEmail");

        entity.Property(e => e.Smtpemail)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("SMTPEmail");

        entity.HasOne(d => d.Client)
            .WithMany(p => p.LawPracticeUsers)
            .HasForeignKey(d => d.ClientId)
            .HasConstraintName("FKLawPracticeUserClientId");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.LawPracticeUsers)
            .HasForeignKey(d => d.LawPracticeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLawPracticeUserLawPracticeId");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.LawPracticeUsers)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLawPracticeUserLoginDetailId");
    }
}
