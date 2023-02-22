using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientLawPracticeConfiguration : IEntityTypeConfiguration<ClientLawPractice>
{
    public void Configure(EntityTypeBuilder<ClientLawPractice> entity)
    {
        entity.ToTable(TableNames.ClientLawPractice);

        entity.HasKey(e => e.Id).HasName("PKClientLawPractice");

        entity.Property(e => e.Id).HasColumnName("ClientLawPracticeId");

        entity.HasIndex(e => e.ClientId, "FKClientLawPracticeClientId");

        entity.HasIndex(e => e.LawPracticeId, "FKClientLawPracticeLawPracticeId");

        entity.Property(e => e.AttyHourRate).HasColumnType("money");

        entity.Property(e => e.Enabled)
            .IsRequired()
        .HasDefaultValueSql("((1))");

        entity.Property(e => e.FcldoesTitle)
            .IsRequired()
            .HasColumnName("FCLDoesTitle")
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.FirmwareUser)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.LawPracticeState)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.HasOne(d => d.Client)
            .WithMany(p => p.ClientLawPractices)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientLawPracticeClientId");

        entity.HasOne(d => d.LawPractice)
            .WithMany(p => p.ClientLawPractices)
            .HasForeignKey(d => d.LawPracticeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientLawPracticeLawPracticeId");
    }
}
