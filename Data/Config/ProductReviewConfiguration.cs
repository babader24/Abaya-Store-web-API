using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbayaStore.Models;

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
		}
	}
}
