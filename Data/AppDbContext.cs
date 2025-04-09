using AbayaStore.Models;
using Microsoft.EntityFrameworkCore;

namespace AbayaStore.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			
		}

		public DbSet<AuditLog> AuditLogs { get; set; }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Offer> Offers { get; set; }
		public DbSet<OfferProduct> OfferProducts { get; set; }
		public DbSet<OrderDetaile> OrderDetailes { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductReview> ProductReviews { get; set; }
		public DbSet<ShippingInfo> ShippingInfos { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<WishList> WishLists { get; set; }
		public DbSet<WishListItem> WishListItems { get; set; }
		public DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; }
		public DbSet<PaymentTransaction> PaymentTransactions { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}
	}
}
