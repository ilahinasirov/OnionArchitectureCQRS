using Application.Dto;
using Application.Interfaces.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Wrappers;

namespace Application.Features.Queries.GetAllProducts
{
	public class GetAllProductsQuery:IRequest<ServiceResponse<List<ProductViewDto>>> 
	{
		/*
		public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductViewDto>>
		{   // GetAllProductsQuery request olaraq alib List<ProductViewDto> response olaraq gonderirik. 
			
			
			private readonly IProductRepository productRepository;
            public GetAllProductsQueryHandler(IProductRepository productRepository)
            {
                this.productRepository = productRepository;
            }

            
            public async Task<List<ProductViewDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
			{
				// burada casting ,mapping ishlemini heyata kechireceyik.

				var products = await productRepository.GetAllAsync(); // bu bize Opshi product donderir deye mapping ishletmeliyik.


				return products.Select(x => new ProductViewDto() // mapping evezine manual olaraq casting etmek.
				{
					Id = x.Id,
				    Name = x.Name,
				}).ToList();
			}
		}
		*/
	}

}
