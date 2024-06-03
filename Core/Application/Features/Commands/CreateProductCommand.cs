using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Wrappers;

namespace Application.Features.Commands
{
	public class CreateProductCommand : IRequest<ServiceResponse<Guid>>

	{
		public string Name { get; set; }
		public decimal Value { get; set; }
		public int Quantity { get; set; }

	}
}
