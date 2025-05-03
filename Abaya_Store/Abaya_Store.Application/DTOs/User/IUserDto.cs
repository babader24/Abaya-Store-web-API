namespace Abaya_Store.Application.DTOs.User
{
	public interface IUserDto
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
