using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LoginDetailConfiguration : IEntityTypeConfiguration<LoginDetail>
{
    public void Configure(EntityTypeBuilder<LoginDetail> entity)
    {
        entity.ToTable(TableNames.LoginDetail);

        entity.HasKey(e => e.Id).HasName("PKLoginDetail");

        entity.Property(e => e.Id).HasColumnName("LoginDetailId");

        entity.HasIndex(e => e.ClientId, "FKLoginDetailClientId");

        entity.HasIndex(e => e.LawPracticeId, "FKLoginDetailLawPracticeId");

        entity.HasIndex(e => e.LocalCounselId, "FKLoginDetailLocalCounselId");

        entity.HasIndex(e => e.LoginTypeLid, "FKLoginTypeLid");

        entity.HasIndex(e => e.LoginId, "UDX_LogonInfo")
        .IsUnique();

        entity.Property(e => e.Address1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.BarNumber)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.CanAccessMenu).HasDefaultValueSql("((0))");

        entity.Property(e => e.CanAccessReports).HasDefaultValueSql("((0))");

        entity.Property(e => e.City)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CompanyName)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.CurrentToken)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.EnforcePasswordPol)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.Fax)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.IsAcceptTermsandConditions).HasDefaultValueSql("((1))");

        entity.Property(e => e.IsApproved).HasDefaultValueSql("((1))");

        entity.Property(e => e.IsEnabled)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.IsLocked).HasColumnName("isLocked");

        entity.Property(e => e.IsSuperAdmin).HasDefaultValueSql("((0))");

        entity.Property(e => e.IsSysAdmin).HasColumnName("isSysAdmin");

        entity.Property(e => e.LastPasswordChange)
            .HasMaxLength(10)
            .IsUnicode(false)
            .IsFixedLength();

        entity.Property(e => e.LoginId)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("LoginID");

        entity.Property(e => e.LoginPwd)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("LoginPWD");

        entity.Property(e => e.AccessToken)
            .HasMaxLength(2500)
            .IsUnicode(false)
            .HasColumnName("AccessToken");

        entity.Property(e => e.LoginUserName)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.LogonIp)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("LogonIP");

        entity.Property(e => e.PasswordExpiresIn).HasDefaultValueSql("((45))");

        entity.Property(e => e.PendingAttemptCount).HasDefaultValueSql("((3))");

        entity.Property(e => e.Phone)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.PhoneAppCode)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.State)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.TermsandConditionsAcceptDate).HasDefaultValueSql("(getdate())");

        entity.Property(e => e.Zip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.Client)
            .WithMany(p => p.LoginDetails)
            .HasForeignKey(d => d.ClientId)
            .HasConstraintName("FKLoginDetailClientId");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.LoginDetails)
            .HasForeignKey(d => d.LawPracticeId)
            .HasConstraintName("FKLoginDetailLawPracticeId");

        entity.HasOne(d => d.LocalCounsel)
            .WithMany(p => p.LoginDetails)
            .HasForeignKey(d => d.LocalCounselId)
            .HasConstraintName("FKLoginDetailLocalCounselId");

        entity.HasOne(d => d.LoginTypeL)
            .WithMany(p => p.LoginDetails)
            .HasForeignKey(d => d.LoginTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKLoginTypeLid");
    }
}
