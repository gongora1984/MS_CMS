using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class CaseCommentWhiteboardConfiguration : IEntityTypeConfiguration<CaseCommentWhiteboard>
{
    public void Configure(EntityTypeBuilder<CaseCommentWhiteboard> entity)
    {
        entity.ToTable(TableNames.CaseCommentWhiteboard);

        entity.HasKey(e => e.Id).HasName("PKCaseCommentWhiteboard");

        entity.Property(e => e.Id).HasColumnName("CaseCommentWhiteboardId");

        entity.HasIndex(e => e.CaseId, "FKCaseCommentWhiteboardCaseId");

        entity.HasIndex(e => e.ClientJobId, "FKCaseCommentWhiteboardClientJobId");

        entity.HasIndex(e => e.CommentTypeLid, "FKCaseCommentWhiteboardCommentTypeLid");

        entity.Property(e => e.CommentText).IsUnicode(false);

        entity.HasOne(d => d.Case)
            .WithMany(p => p.CaseCommentWhiteboards)
            .HasForeignKey(d => d.CaseId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCommentWhiteboardCaseId");

        entity.HasOne(d => d.ClientJob)
            .WithMany(p => p.CaseCommentWhiteboards)
            .HasForeignKey(d => d.ClientJobId)
            .HasConstraintName("FKCaseCommentWhiteboardClientJobId");

        entity.HasOne(d => d.CommentType)
            .WithMany(p => p.CaseCommentWhiteboards)
            .HasForeignKey(d => d.CommentTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCaseCommentWhiteboardCommentTypeLid");
    }
}
