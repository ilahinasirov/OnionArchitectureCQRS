using Application.Dto;
using Application.Features.Queries.GetAllProducts;
using Application.Interfaces.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Wrappers;
using AutoMapper;

namespace Application.Features.Handlers.QueryHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
    {      // GetAllProductsQuery request olaraq alib List<ProductViewDto> response olaraq gonderirik. 


        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;

        }


        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            // burada casting ,mapping ishlemini heyata kechireceyik.

            var products = await _productRepository.GetAllAsync(); // bu bize Opshi product donderir deye mapping ishletmeliyik.


            var viewModel = _mapper.Map<List<ProductViewDto>>(products);

            //var dto= products.Select(x => new ProductViewDto() // mapping evezine manual olaraq casting etmek.
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //}).ToList();

            return new ServiceResponse<List<ProductViewDto>>(viewModel);
        }
    }
}
