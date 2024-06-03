using Application.Interfaces.Repository;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Dto;
using Application.Features.Commands;
using Application.Features.Queries.GetAllProducts;
using Application.Features.Queries.GetProductById;
using MediatR;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ProductController(IMediator mediator)
		{
			_mediator = mediator;
		}


		[HttpGet] 
        public async Task<IActionResult> Get()
        {
	        var query = new GetAllProductsQuery();
	        return Ok(await _mediator.Send(query));
        }

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById( Guid id)
		{
			var query = new GetProductByIdQuery(){Id = id};
			return Ok(await _mediator.Send(query));
		}


		[HttpPost]
		public async Task<IActionResult> Post(CreateProductCommand command)
		{
			return Ok(await _mediator.Send(command));
		}

    }
}
