using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseCommentConfiguration : IEntityTypeConfiguration<CaseComment>
{
    public void Configure(EntityTypeBuilder<CaseComment> entity)
    {
        entity.ToTable(TableNames.CaseComment);

        entity.HasKey(e => e.Id).HasName("PKCaseComment");

        entity.Property(e => e.Id).HasColumnName("CaseCommentId");

        entity.HasIndex(e => e.CaseId, "FKCaseCommentCaseId");

        entity.HasIndex(e => e.ClientJobId, "FKCaseCommentClientJobId");

        entity.HasIndex(e => e.CommentTypeLid, "FKCaseCommentCommentTypeLid");

        entity.Property(e => e.CommentText).IsUnicode(false);

        entity.HasOne(d => d.Case)
            .WithMany(p => p.CaseComments)
            .HasForeignKey(d => d.CaseId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCommentCaseId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseComments)
            .HasForeignKey(d => d.ClientJobId)
            .HasConstraintName("FKCaseCommentClientJobId");

        entity.HasOne(d => d.CommentType)
            .WithMany(p => p.CaseComments)
            .HasForeignKey(d => d.CommentTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCommentCommentTypeLid");
    }
}
