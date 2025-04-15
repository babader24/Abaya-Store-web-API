using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using namespace Abaya_Store.Domain.Entities;

namespace AbayaStore.Configurations
{
	public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
	{
		public void Configure(EntityTypeBuilder<AuditLog> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Action).IsRequired().HasMaxLength(255);

			builder.ToTable("AuditLogs");

		}
	}
}
