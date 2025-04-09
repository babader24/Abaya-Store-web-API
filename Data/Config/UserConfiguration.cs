using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

namespace AbayaStore.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			
			builder.Property(u => u.UserName).IsRequired().HasMaxLength(100);
			builder.Property(u => u.Position).IsRequired().HasMaxLength(100);
			builder.Property(u => u.Permissions).IsRequired();

			builder.HasMany(u => u.AuditLogs)
				   .WithOne(a => a.User)
				   .HasForeignKey(a => a.UserId)
				   .OnDelete(DeleteBehavior.Cascade);

			builder.ToTable("Users");
		}
	}
}
