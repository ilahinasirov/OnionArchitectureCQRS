using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
	public static class ServiceRegistration //  extentions for sign dependency injection
	{
		public static void AddPersistenceService(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddDbContext<ApplicationDbContext>(opt=>opt.UseInMemoryDatabase("memoryDb"));
			serviceCollection.AddTransient<IProductRepository, ProductRepository>();
		}
	}
}
