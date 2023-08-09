using System;
using OnionArchitectureExample.Domain.Entities.Common;

namespace OnionArchitectureExample.Domain.Entities
{
	public class Product: BaseEntity
	{
		public string? Name { get; set; }
		public int Stock { get; set; }
		public float Price { get; set; }
	}
}

