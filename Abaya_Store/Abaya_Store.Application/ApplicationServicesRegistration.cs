using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
			try
			{
				services.AddAutoMapper(Assembly.GetExecutingAssembly());
				services.AddMediatR(typeof(ApplicationServicesRegistration).Assembly);
			}
			catch (ReflectionTypeLoadException ex)
			{
				foreach (var loaderException in ex.LoaderExceptions)
				{
					Console.WriteLine(loaderException.Message);
				}
			}

			return services;
        }
	}
}
