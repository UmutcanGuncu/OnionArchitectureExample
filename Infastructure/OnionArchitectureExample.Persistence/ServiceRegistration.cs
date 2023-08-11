using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Persistence.Contexts;
using OnionArchitectureExample.Persistence.Repositories;

namespace OnionArchitectureExample.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceService ( this IServiceCollection services)
		{
            services.AddDbContext<ETicaretAPIDbContex>(opt => opt.UseNpgsql(Configurations.ConnectionString));

			services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        }
	}
}

