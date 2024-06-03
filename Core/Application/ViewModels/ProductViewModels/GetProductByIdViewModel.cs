using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.ProductViewModels
{
	public class GetProductByIdViewModel
	{
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public string Name { get; set; }
		public decimal Value { get; set; }
		public int Quantity { get; set; }
	}
}
