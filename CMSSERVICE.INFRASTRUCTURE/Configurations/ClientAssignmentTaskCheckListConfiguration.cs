using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentTaskCheckListConfiguration : IEntityTypeConfiguration<ClientAssignmentTaskCheckList>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentTaskCheckList> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentTaskCheckList);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentTaskCheckList");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentTaskCheckListId");

        entity.HasIndex(e => e.ClientAssignmentTaskId, "FKClientAssignmentTaskCheckListClientAssignmentTaskId");

        entity.HasIndex(e => e.CheckListTypeLid, "FKClientAssignmentTaskCheckListTypeLid");

        entity.Property(e => e.AssignmentsNo)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.AssignmentsYes)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.CustomControlName)
            .HasMaxLength(100)
        .IsUnicode(false);

        entity.Property(e => e.CustomWorkScheduleName)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.DefaultValue)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.DropSql)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.DropUpdaterControl)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.KillAssignmentSchedule)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.MergeToken)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.MirrorToComment)
            .HasColumnName("mirrorToComment")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.OrderBy)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.ProcessCommand)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.RulesDefaultAssignments)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.StartsFileAssignmentsTaskId).HasColumnName("StartsFileAssignmentsTaskID");

        entity.Property(e => e.TaskListItemTag)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.TaskListName)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.UpdateField)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.UpdateKeyField)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.UpdateKeyValue)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.UpdateTable)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.UseTaskListItemId).HasColumnName("UseTaskListItemID");

        entity.HasOne(d => d.CheckListType)
            .WithMany(p => p.ClientAssignmentTaskCheckLists)
            .HasForeignKey(d => d.CheckListTypeLid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskCheckListTypeLid");

        entity.HasOne(d => d.ClientAssignmentTask)
            .WithMany(p => p.ClientAssignmentTaskCheckLists)
            .HasForeignKey(d => d.ClientAssignmentTaskId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskCheckListClientAssignmentTaskId");
    }
}
