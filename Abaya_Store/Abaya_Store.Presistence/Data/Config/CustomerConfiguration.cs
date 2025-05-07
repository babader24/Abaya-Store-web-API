using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
namespace AbayaStore.Configurations
{
	public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			
			builder.Property(c => c.Notes).HasMaxLength(1000);

			builder.HasOne(c => c.Cart)
				   .WithOne(cart => cart.Customer)
				   .HasForeignKey<Cart>(c => c.CustomerId);

			builder.HasOne(c => c.WishList)
				   .WithOne(w => w.Customer)
				   .HasForeignKey<WishList>(w => w.CustomerId);

			builder.HasMany(c => c.Bills)
				   .WithOne(b => b.Customer)
				   .HasForeignKey(b => b.CustomerId);

			builder.HasMany(c => c.Reviews)
				   .WithOne()
				   .HasForeignKey(r => r.CustomerId);

			builder.ToTable("Customers");

			builder.HasData(
	new Customer
	{
		Id = 1,
		FirstName = "Ali",
		LastName = "Ahmed",
		Email = "ali@example.com",
		Phone = "777777777",
		Address = "Aden",
		Password = "hashedpassword",
		Role = 0,
		status = 1,
		IsSubscribedToNewsletter = true,
		Notes = "VIP Customer",
		RegisterDate = new DateTime(2025, 5, 5)
	}
	);

		}
	}
}
