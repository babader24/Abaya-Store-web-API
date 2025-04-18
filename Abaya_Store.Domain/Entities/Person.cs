﻿namespace Abaya_Store.Domain.Entities
{
	public class Person
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
		public byte status { get; set; }
	}
}

