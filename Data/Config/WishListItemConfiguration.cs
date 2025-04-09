using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

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
		}
	}
}
