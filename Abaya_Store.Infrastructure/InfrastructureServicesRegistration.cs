using Abaya_Store.Application.Contracts.Infrastructture;
using Abaya_Store.Application.Model;
using Abaya_Store.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
		public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
			services.AddTransient<IEmailSender, EmailSender>();

			return services;
		}

	}
}
