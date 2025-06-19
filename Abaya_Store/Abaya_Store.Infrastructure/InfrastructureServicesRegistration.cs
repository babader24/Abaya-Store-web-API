using Abaya_Store.Application.Contracts.Infrastructture;
using Abaya_Store.Application.Model.Email;
using Abaya_Store.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Abaya_Store.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
		public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
			services.AddTransient<IEmailSender, EmailSender>();

			return services;
		}

	}
}
