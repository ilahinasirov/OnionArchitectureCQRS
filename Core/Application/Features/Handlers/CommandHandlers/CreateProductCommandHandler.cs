using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Commands;
using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Handlers.CommandHandlers
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
	{

		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			var product = _mapper.Map<Product>(request);
			await _productRepository.AddAsync(product);
			return new ServiceResponse<Guid>(product.Id);
		}
	}
}
