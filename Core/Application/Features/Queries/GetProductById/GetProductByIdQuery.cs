using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto;
using Application.ViewModels.ProductViewModels;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Queries.GetProductById
{
	public class GetProductByIdQuery:IRequest<ServiceResponse<GetProductByIdViewModel>>
	{
		public Guid Id { get; set; }
	}
}
