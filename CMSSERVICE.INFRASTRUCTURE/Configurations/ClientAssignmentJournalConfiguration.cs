using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentJournalConfiguration : IEntityTypeConfiguration<ClientAssignmentJournal>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentJournal> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentJournal);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentJournal");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentJournalId");

        entity.HasIndex(e => e.ClientAssignmentId, "FKClientAssignmentJournalClientAssignmentId");

        entity.HasIndex(e => e.LoginDetailId, "FKClientAssignmentJournalLoginDetailId");

        entity.HasOne(d => d.ClientAssignment)
            .WithMany(p => p.ClientAssignmentJournals)
            .HasForeignKey(d => d.ClientAssignmentId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentJournalClientAssignmentId");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.ClientAssignmentJournals)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentJournalLoginDetailId");
    }
}
