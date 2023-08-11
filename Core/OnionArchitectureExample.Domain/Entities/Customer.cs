using System;
using OnionArchitectureExample.Domain.Entities.Common;

namespace OnionArchitectureExample.Domain.Entities
{
	public class Customer: BaseEntity
	{
		public string? Name { get; set; }
		public ICollection<Order>? Orders { get; set; }
	}
}

