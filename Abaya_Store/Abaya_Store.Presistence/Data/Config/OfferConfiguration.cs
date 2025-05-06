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

			builder.HasData(
				new Offer { Id = 1, DiscountPercentage = 10, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(10) },
				new Offer { Id = 2, DiscountPercentage = 15, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(15) });
		}
	}
}
