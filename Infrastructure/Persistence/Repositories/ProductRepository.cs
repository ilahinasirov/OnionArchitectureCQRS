using Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Repository;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
	public class ProductRepository:GenericRepository<Product>,IProductRepository
	{

		public ProductRepository(ApplicationDbContext dbContext):base(dbContext)
		{
			
		}
	}
}
