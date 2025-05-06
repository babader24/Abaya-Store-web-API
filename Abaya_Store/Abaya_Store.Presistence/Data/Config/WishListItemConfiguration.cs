using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
namespace AbayaStore.Configurations
{
	public class WishListItemConfiguration : IEntityTypeConfiguration<WishListItem>
	{
		public void Configure(EntityTypeBuilder<WishListItem> builder)
		{
			builder.HasKey(w => w.Id);

			builder.HasOne(w => w.WishList)
				   .WithMany(wl => wl.Items)
				   .HasForeignKey(w => w.WishListId);

			builder.HasOne(w => w.Product)
				   .WithMany()
				   .HasForeignKey(w => w.ProductId);

			builder.ToTable("WishListItems");

			builder.HasData(
				new WishListItem
				{
					Id = 1,
					WishListId = 1,
					ProductId = 2,
					DateAdded = DateTime.Now
				});

		}
	}
}
