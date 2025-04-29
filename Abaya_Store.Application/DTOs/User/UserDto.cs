using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.User
{
	public class UserDto
	{
		public int Id { get; set; }

		public string UserName { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string? Address { get; set; }
		public string? Image { get; set; }
		public byte Role { get; set; }
		public byte Status { get; set; }

		public DateTime CreatedAt { get; set; }
		public DateTime? LastLogin { get; set; }
		public string Position { get; set; }
		public byte Permissions { get; set; }

		public List<string> AuditActions { get; set; }
	}
	public class UserUpdateDto : IUserDto
	{
		public int Id { get; set; }

		public string UserName { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string? Address { get; set; }
		public string? Image { get; set; }
		public string Password { get; set; }
		public byte Role { get; set; }
		public byte Status { get; set; }

		public string Position { get; set; }
		public byte Permissions { get; set; }
	}
	public class UserListDto
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Position { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? LastLogin { get; set; }
	}

	public class UserCreateDto : IUserDto
	{
		public string UserName { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string? Address { get; set; }
		public string? Image { get; set; }
		public string Password { get; set; }
		public byte Role { get; set; }
		public byte Status { get; set; }

		public string Position { get; set; }
		public byte Permissions { get; set; }
	}
}
