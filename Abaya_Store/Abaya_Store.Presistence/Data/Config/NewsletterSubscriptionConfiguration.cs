using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Abaya_Store.Domain.Entities;

public class NewsletterSubscriptionConfiguration : IEntityTypeConfiguration<NewsletterSubscription>
{
	public void Configure(EntityTypeBuilder<NewsletterSubscription> builder)
	{
		builder.ToTable("NewsletterSubscriptions");

		builder.HasKey(n => n.Id);

		builder.Property(n => n.Email)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(n => n.SubscribedAt)
			.HasColumnType("datetime");

		builder.Property(n => n.IsActive)
			.IsRequired();

		
		builder.HasOne(n => n.Customer)
			.WithMany(c => c.NewsletterSubscriptions) 
			.HasForeignKey(n => n.CustomerId)
			.OnDelete(DeleteBehavior.SetNull); 
	}
}

