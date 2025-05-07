using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
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

			builder.HasData(
	new User
	{
		Id = 2,
		FirstName = "Admin",
		LastName = "User",
		Email = "admin@example.com",
		Phone = "123456789",
		Address = "Admin Office",
		Password = "adminpass",
		Role = 1,
		status = 1,
		UserName = "admin",
		CreatedAt = new DateTime(2025, 5, 5),
		Position = "Administrator",
		Permissions = 255
	}
);


		}
	}
}
