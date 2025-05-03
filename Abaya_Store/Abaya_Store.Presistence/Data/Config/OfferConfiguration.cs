using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;

namespace AbayaStore.Configurations
{
	public class OfferConfiguration : IEntityTypeConfiguration<Offer>
	{
		public void Configure(EntityTypeBuilder<Offer> builder)
		{
			builder.HasKey(o => o.Id);
			builder.Property(o => o.DiscountPercentage).IsRequired();
			builder.Property(o => o.StartDate).IsRequired();
			builder.Property(o => o.EndDate).IsRequired();

			builder.ToTable("Offers");
		}
	}
}
