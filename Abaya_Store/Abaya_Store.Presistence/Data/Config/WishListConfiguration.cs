using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
namespace AbayaStore.Configurations
{
	public class WishListConfiguration : IEntityTypeConfiguration<WishList>
	{
		public void Configure(EntityTypeBuilder<WishList> builder)
		{
			builder.HasKey(w => w.Id);

			builder.ToTable("WishList");
		}
	}
}
