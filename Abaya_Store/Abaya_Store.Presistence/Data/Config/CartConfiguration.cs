using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using  Abaya_Store.Domain.Entities;

namespace AbayaStore.Configurations
{
	public class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.HasKey(c => c.Id);

			builder.ToTable("Cart");

			builder.HasData(
				new Cart
				{
					Id = 1,
					CustomerId = 1
				});




		}
	}
}
