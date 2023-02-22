using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ListItemConfiguration : IEntityTypeConfiguration<ListItem>
{
    public void Configure(EntityTypeBuilder<ListItem> entity)
    {
        entity.ToTable(TableNames.ListItem);

        entity.HasKey(e => e.Id).HasName("PKListItem");

        entity.Property(e => e.Id).HasColumnName("ListItemId");

        entity.Property(e => e.DefValue1)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.DefValue2)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.DefValue3)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.DefValue4)
            .HasMaxLength(200)
        .IsUnicode(false);

        entity.Property(e => e.DefValue5)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.DefValue6)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.DisplayText)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.Enabled)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.InvokeAssignment)
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.ListOrder).HasDefaultValueSql("((1))");

        entity.Property(e => e.MergeText)
            .HasMaxLength(1000)
            .IsUnicode(false);

        entity.Property(e => e.MergeValue)
            .HasMaxLength(500)
            .IsUnicode(false);

        entity.Property(e => e.SystemCategory)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('System')");

        entity.Property(e => e.SystemTag)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.Value1)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.Value2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.HasOne(d => d.Client)
                    .WithMany(p => p.ListItems)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListItem_Client");
    }
}
