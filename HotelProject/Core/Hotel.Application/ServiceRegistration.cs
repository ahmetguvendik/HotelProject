using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.Application
{
	public static class ServiceRegistration
	{
		public static void AddMediatorService(this IServiceCollection services)
		{

			services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(ServiceRegistration).GetTypeInfo().Assembly));
		}
	}
}

