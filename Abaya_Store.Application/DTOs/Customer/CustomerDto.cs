using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Customer
{
	public class CustomerDto
	{
		public int Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string? Address { get; set; }
		public string? Image { get; set; }
		public byte Role { get; set; }
		public byte Status { get; set; }

		public DateTime RegisterDate { get; set; }
		public bool IsSubscribedToNewsletter { get; set; }
		public string? Notes { get; set; }

		public List<string> BillNumbers { get; set; }
		public List<string> ReviewSummaries { get; set; }
	}

	public class CustomerListDto
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		public DateTime RegisterDate { get; set; }
		public bool IsSubscribedToNewsletter { get; set; }
	}

	public class CustomerUpdateDto
	{
		public int Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string? Address { get; set; }
		public string? Image { get; set; }
		public string Password { get; set; }
		public byte Role { get; set; }
		public byte Status { get; set; }

		public bool IsSubscribedToNewsletter { get; set; }
		public string? Notes { get; set; }
	}
	public class CustomerCreateDto
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string? Address { get; set; }
		public string? Image { get; set; }
		public string Password { get; set; }
		public byte Role { get; set; }
		public byte Status { get; set; }

		public bool IsSubscribedToNewsletter { get; set; }
		public string? Notes { get; set; }
	}

}
