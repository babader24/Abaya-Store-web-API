﻿namespace Abaya_Store.Domain.Entities
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Product> Products { get; set; } = new List<Product>();
	}
}
