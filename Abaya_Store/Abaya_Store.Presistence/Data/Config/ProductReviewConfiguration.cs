using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;
namespace AbayaStore.Configurations
{
	public class ProductReviewConfiguration : IEntityTypeConfiguration<ProductReview>
	{
		public void Configure(EntityTypeBuilder<ProductReview> builder)
		{
			builder.HasKey(pr => pr.Id);
			builder.Property(pr => pr.Rating).IsRequired();
			builder.Property(pr => pr.Comment).HasMaxLength(1000);

			builder.HasOne(pr => pr.Product)
				   .WithMany(p => p.ProductReviews)
				   .HasForeignKey(pr => pr.ProductId);

			builder.ToTable("ProductReviews");

			builder.HasData(
				new ProductReview
				{
					Id = 1,
					ProductId = 1,
					CustomerId = 1,
					Rating = 5,
					Comment = "Excellent quality!",
					Date = DateTime.Now.AddDays(-1)
				},
				new ProductReview
				{
					Id = 2,
					ProductId = 2,
					CustomerId = 1,
					Rating = 4,
					Comment = "Very good, but packaging could be better.",
					Date = DateTime.Now
				});

		}
	}
}
