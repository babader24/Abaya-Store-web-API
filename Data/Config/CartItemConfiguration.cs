using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

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

		}
	}
}
