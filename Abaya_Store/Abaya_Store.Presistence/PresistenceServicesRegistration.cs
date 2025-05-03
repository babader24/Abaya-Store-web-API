using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Persistence;
using Abaya_Store.Presistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Presistence
{
    public static class PresistenceServicesRegistration
    {
		public static IServiceCollection ConfigurePresistenceServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(options =>
			options.UseSqlServer(configuration.GetConnectionString("AbayaStoreDB")));


			services.AddScoped(typeof(IGenaricRepository<>), typeof(GenaricRepository<>));

			services.AddScoped<IAuditLogRepository, AuditLogRepository>();
			services.AddScoped<IBillRepository, BillRepository>();
			services.AddScoped<ICartItemRepository, CartItemRepository>();
			services.AddScoped<ICartRepository, CartRepository>();
			services.AddScoped<ICustomerRepository, CustomerRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<INewsletterSubscriptionRepository, NewsletterSubscriptionRepository>();
			services.AddScoped<IOfferProductRepository, OfferProductRepository>();
			services.AddScoped<IOfferRepository, OfferRepository>();
			services.AddScoped<IOrderDetaileRepository, OrderDetailRepository>();
			services.AddScoped<IPaymentTransactionRepository, PaymentTransactionRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IProductReviewRepository, ProductReviewRepository>();
			services.AddScoped<IShippingInfoRepository, ShippingInfoRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IWishListItemRepository, WishListItemRepository>();
			services.AddScoped<IWishListRepository, WishListRepository>();

			return services;
		}

	}
}
