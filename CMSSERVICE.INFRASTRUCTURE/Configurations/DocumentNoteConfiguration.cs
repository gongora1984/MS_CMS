using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class DocumentNoteConfiguration : IEntityTypeConfiguration<DocumentNote>
{
    public void Configure(EntityTypeBuilder<DocumentNote> entity)
    {
        entity.ToTable(TableNames.DocumentNote);

        entity.HasKey(e => e.Id).HasName("PKDocumentNote");

        entity.Property(e => e.Id).HasColumnName("DocumentNoteId");

        entity.HasIndex(e => e.LoginDetailId, "FKDocumentNoteByUserId");

        entity.HasIndex(e => e.DocumentRepositoryId, "FKDocumentNoteDocumentRepositoryId");

        entity.Property(e => e.NoteOn).HasDefaultValueSql("(getdate())");

        entity.Property(e => e.NoteText)
            .HasMaxLength(4000)
        .IsUnicode(false);

        entity.HasOne(d => d.DocumentRepository)
            .WithMany(p => p.DocumentNotes)
            .HasForeignKey(d => d.DocumentRepositoryId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentNoteDocumentRepositoryId");

        entity.HasOne(d => d.LoginDetail)
            .WithMany(p => p.DocumentNotes)
            .HasForeignKey(d => d.LoginDetailId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKDocumentNoteByUserId");
    }
}
