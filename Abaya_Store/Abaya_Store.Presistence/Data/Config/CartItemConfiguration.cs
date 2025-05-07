using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using  Abaya_Store.Domain.Entities;

namespace AbayaStore.Configurations
{
	public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
	{
		public void Configure(EntityTypeBuilder<CartItem> builder)
		{
			builder.HasKey(ci => ci.Id);
			builder.HasOne(ci => ci.Cart)
				   .WithMany(c => c.Items)
				   .HasForeignKey(ci => ci.CartId);

			builder.HasOne(ci => ci.Product)
				   .WithMany()
				   .HasForeignKey(ci => ci.ProductId);

			builder.ToTable("CartItems");

			builder.HasData(
				new CartItem
				{
					Id = 1,
					CartId = 1,
					ProductId = 1,
					Quantity = 2,
					DateAdded = new DateTime(2025, 5, 5)
				});



		}
	}
}
