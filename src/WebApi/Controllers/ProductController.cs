using Application.Interfaces.Repository;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Dto;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
        private readonly IProductRepository productRepository;
        public ProductController( IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet] 
        public async Task<IActionResult> Get()
        {
            var allList = await productRepository.GetAllAsync();
            var result = allList.Select(x => new ProductViewDto()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
            return Ok(result);
        }
    }
}
