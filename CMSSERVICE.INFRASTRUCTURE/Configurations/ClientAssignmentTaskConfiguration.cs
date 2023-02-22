using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientAssignmentTaskConfiguration : IEntityTypeConfiguration<ClientAssignmentTask>
{
    public void Configure(EntityTypeBuilder<ClientAssignmentTask> entity)
    {
        entity.ToTable(TableNames.ClientAssignmentTask);

        entity.HasKey(e => e.Id).HasName("PKClientAssignmentTask");

        entity.Property(e => e.Id).HasColumnName("ClientAssignmentTaskId");

        entity.HasIndex(e => e.AssocMergePackageId, "FKClientAssignmentTaskAssocMergePackageId");

        entity.HasIndex(e => e.ClientId, "FKClientAssignmentTaskClientId");

        entity.HasIndex(e => e.JobTypeId, "FKClientAssignmentTaskJobTypeId");

        entity.HasIndex(e => e.RequiresDocumentId, "FKClientAssignmentTaskRequiresDocumentId");

        entity.HasIndex(e => e.ParentTaskId, "Ref87213");

        entity.Property(e => e.AblbiDirectional).HasColumnName("ABLBiDirectional");

        entity.Property(e => e.AcctFeeApprovalCoaitemId).HasColumnName("AcctFeeApprovalCOAItemId");

        entity.Property(e => e.AlertEmailAddressWhenComplete)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.AlertOthersOnReproject)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.AssignActionDate)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.AssignmentCode)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.AssignmentName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.AutoAssignTheseWhenComplete)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.AutoCompleteTaskIfExists)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.CalendarColor)
            .HasMaxLength(25)
            .IsUnicode(false);

        entity.Property(e => e.Category)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.ClaimState)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.ClientSystemCommand)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.ClientSystemDefualtCode)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.CompleteActionDateName)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CompleteCommand)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.CompleteOnChainCompletion)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CreateCommand)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.DefaultAssignmentText)
            .HasMaxLength(400)
            .IsUnicode(false);

        entity.Property(e => e.DefaultSecUserId)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DeleteOnComplete)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.GroupCategory1).HasDefaultValueSql("((-1))");

        entity.Property(e => e.GroupCategory2).HasDefaultValueSql("((-1))");

        entity.Property(e => e.GroupCategory3).HasDefaultValueSql("((-1))");

        entity.Property(e => e.GroupCategory4).HasDefaultValueSql("((-1))");

        entity.Property(e => e.GroupCategory5).HasDefaultValueSql("((-1))");

        entity.Property(e => e.GroupCategory6).HasDefaultValueSql("((-1))");

        entity.Property(e => e.GroupCategory7).HasDefaultValueSql("((-1))");

        entity.Property(e => e.HasCheckList).HasColumnName("hasCheckList");

        entity.Property(e => e.HoldWorkOfAssignments)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.HoldWorkOnDepts)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.IgnorHoldsFromTaskIds)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationCode1)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationCode2)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.IntegrationTaskCode)
            .HasMaxLength(75)
            .IsUnicode(false);

        entity.Property(e => e.IsAttyreview).HasColumnName("isATTYReview");

        entity.Property(e => e.IsClientCompleteTask).HasColumnName("isClientCompleteTask");

        entity.Property(e => e.IsClientTask).HasColumnName("isClientTask");

        entity.Property(e => e.IsConsoleCompleteJob).HasColumnName("isConsoleCompleteJob");

        entity.Property(e => e.IsDocumentApprovalTask).HasColumnName("isDocumentApprovalTask");

        entity.Property(e => e.IsHearingEvent).HasColumnName("isHearingEvent");

        entity.Property(e => e.IsLawPracticeCompleteTask).HasColumnName("isLawPracticeCompleteTask");

        entity.Property(e => e.IsLawPracticeTask).HasColumnName("isLawPracticeTask");

        entity.Property(e => e.IsLocalCounselCompleteTask).HasColumnName("isLocalCounselCompleteTask");

        entity.Property(e => e.IsLocalCounselTask)
            .HasColumnName("isLocalCounselTask")
            .HasDefaultValueSql("((0))");

        entity.Property(e => e.IsQueueTask)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.IsStartupTask).HasColumnName("isStartupTask");

        entity.Property(e => e.LawActionType)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.MergeDocumentOnComplete)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.MergeDocumentOnStart)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.OptionalCompletionAssignments)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.RequireCoaapproval).HasColumnName("RequireCOAApproval");

        entity.Property(e => e.RequiresComplettion)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.RunCreateCmdOnTargetDate).HasColumnName("runCreateCmdOnTargetDate");

        entity.Property(e => e.StartOnChainCompletion)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.VoidOnComplete)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.WebPortalTool)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.HasOne(d => d.AssocMergePackage)
            .WithMany(p => p.ClientAssignmentTasks)
            .HasForeignKey(d => d.AssocMergePackageId)
            .HasConstraintName("FKClientAssignmentTaskAssocMergePackageId");

        entity.HasOne(d => d.Client)
            .WithMany(p => p.ClientAssignmentTasks)
            .HasForeignKey(d => d.ClientId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskClientId");

        entity.HasOne(d => d.JobType)
            .WithMany(p => p.ClientAssignmentTasks)
            .HasForeignKey(d => d.JobTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKClientAssignmentTaskJobTypeId");

        entity.HasOne(d => d.ParentTask)
            .WithMany(p => p.InverseParentTask)
            .HasForeignKey(d => d.ParentTaskId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("RefClientAssignmentTask213");

        entity.HasOne(d => d.RequiresDocument)
            .WithMany(p => p.ClientAssignmentTasks)
            .HasForeignKey(d => d.RequiresDocumentId)
            .HasConstraintName("FKClientAssignmentTaskRequiresDocumentId");
    }
}
