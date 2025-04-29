using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Category
{
	public class CategoryDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<string> ProductNames { get; set; }
	}
	public class CategoryCreateDto : ICategoryDto
	{
		public string Name { get; set; }
	}

	public class CategoryUpdateDto : ICategoryDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class CategoryListDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

}
