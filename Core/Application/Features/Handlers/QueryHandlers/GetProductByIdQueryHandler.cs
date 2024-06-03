using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Application.Features.Queries.GetProductById;
using Application.Interfaces.Repository;
using Application.ViewModels.ProductViewModels;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Features.Handlers.QueryHandlers
{
	public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}

		public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
		{
			var product = await _productRepository.GetByIdAsync(request.Id);

			var viewModel = _mapper.Map<GetProductByIdViewModel>(product);
			return new ServiceResponse<GetProductByIdViewModel>(viewModel);
		}
	}
}
