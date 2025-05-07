using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using  Abaya_Store.Domain.Entities;

namespace AbayaStore.Configurations
{
	public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
	{
		public void Configure(EntityTypeBuilder<AuditLog> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Action).IsRequired().HasMaxLength(255);

			builder.ToTable("AuditLogs");

			builder.HasData(
			new AuditLog
			{
				Id = 1,
				UserId = 2,
				Action = "Login",
				Date = new DateTime(2025, 5, 5)
			});


		}
	}
}
