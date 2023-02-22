using CMSSERVICE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSSERVICE.INFRASTRUCTURE.Configurations;

internal sealed class ClientDepartmentConfiguration : IEntityTypeConfiguration<ClientDepartment>
{
    public void Configure(EntityTypeBuilder<ClientDepartment> entity)
    {
        entity.ToTable(TableNames.ClientDepartment);

        entity.HasKey(e => e.Id).HasName("PKClientDepartment");

        entity.Property(e => e.Id).HasColumnName("ClientDepartmentId");

        entity.HasIndex(e => e.ClientId, "FKClientDepartmentClientId");

        entity.Property(e => e.DepartmentName)
            .HasMaxLength(50)
        .IsUnicode(false);

        entity.Property(e => e.SysCode)
            .HasMaxLength(25)
            .IsUnicode(false)
        .HasColumnName("sysCode");

        entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientDepartments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClientDepartmentClientId");
    }
}
