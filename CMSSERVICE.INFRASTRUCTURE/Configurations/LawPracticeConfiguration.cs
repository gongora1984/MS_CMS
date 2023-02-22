using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class LawPracticeConfiguration : IEntityTypeConfiguration<LawPractice>
{
    public void Configure(EntityTypeBuilder<LawPractice> entity)
    {
        entity.ToTable(TableNames.LawPractice);

        entity.HasKey(e => e.Id).HasName("PKLawPractice");

        entity.Property(e => e.Id).HasColumnName("LawPracticeId");

        entity.HasIndex(e => e.ClientId, "FKLawPracticeClientId");

        entity.HasIndex(e => e.PracticeTypeLid, "FKPracticeTypeLid");

        entity.HasIndex(e => e.ReferralCompanyCode, "UQ__LawPractice__54817C4C")
        .IsUnique();

        entity.Property(e => e.Address1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.Address2)
            .HasMaxLength(150)
        .IsUnicode(false);

        entity.Property(e => e.CardDisplayNumber)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.CardExpirationDate)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.CardName)
            .HasMaxLength(300)
            .IsUnicode(false);

        entity.Property(e => e.CardNumber)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.City)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.ContactBarNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CurrentCmssystem)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasColumnName("CurrentCMSSystem");

        entity.Property(e => e.FaxNumber)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.FirmStateCode)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.HasDevelopmentStaff).HasDefaultValueSql("((0))");

        entity.Property(e => e.HasEfileAbility)
            .HasColumnName("HasEFileAbility")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.LawPracticeUserId).HasColumnName("LawPracticeUserID");

        entity.Property(e => e.PaymentType)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PhoneNumber)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.PracticeContact)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.PracticeLogoLocation)
            .HasMaxLength(300)
            .IsUnicode(false);

        entity.Property(e => e.PracticeName)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.ReferralCompanyCode)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.ServiceEventsLogon)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.ServiceEventsPass)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.ServiceEventsUrl)
            .HasMaxLength(400)
            .IsUnicode(false)
            .HasColumnName("ServiceEventsURL");

        entity.Property(e => e.State)
            .HasMaxLength(5)
            .IsUnicode(false);

        entity.Property(e => e.Zip)
            .HasMaxLength(12)
            .IsUnicode(false);

        entity.HasOne(d => d.Client)
            .WithMany(p => p.LawPractices)
            .HasForeignKey(d => d.ClientId)
            .HasConstraintName("FKLawPracticeClientId");

        entity.HasOne(d => d.PracticeType)
            .WithMany(p => p.LawPractices)
            .HasForeignKey(d => d.PracticeTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKPracticeTypeLid");
    }
}
