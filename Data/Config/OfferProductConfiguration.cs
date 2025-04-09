using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

namespace AbayaStore.Configurations
{
	public class OfferProductConfiguration : IEntityTypeConfiguration<OfferProduct>
	{
		public void Configure(EntityTypeBuilder<OfferProduct> builder)
		{
			builder.HasKey(op => op.Id);

			builder.HasOne(op => op.Offer)
				   .WithMany(o => o.Products)
				   .HasForeignKey(op => op.OfferId);

			builder.HasOne(op => op.Product)
				   .WithMany()
				   .HasForeignKey(op => op.ProductId);

			builder.ToTable("OfferProducts");
		}
	}
}
