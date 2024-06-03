using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
	public static class ServiceRegistration // extentions for sign dependency injection
	{
		private static readonly IServiceCollection _services;
		public static void AddAplicationRegistration(this IServiceCollection services)
		{
			//assembly tanimlayib maperlere veririk ki, oldughumuz asembly-de olan butun mapper ishlemlerini avtomatik map elesin.

			var asmbly = Assembly.GetExecutingAssembly();
			services.AddAutoMapper(asmbly);
			services.AddMediatR(asmbly);
		}
       
    }
}
