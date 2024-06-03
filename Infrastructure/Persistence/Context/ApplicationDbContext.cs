using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.Context
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(new Product()
			{
				Id = Guid.NewGuid(),
				Name = "Pen",
				Value = 10,
				Quantity = 100
			},
			new Product()
			{
				Id = Guid.NewGuid(),
				Name = "Paper",
				Value = 5,
				Quantity = 10
			});

			base.OnModelCreating(modelBuilder);
		}
	}
}
