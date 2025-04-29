namespace Abaya_Store.Application.DTOs.Customer
{
	public interface ICustomerDto
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string Phone { get; set; }
		string? Address { get; set; }
		string? Image { get; set; }
		string Password { get; set; }
		byte Role { get; set; }
		byte Status { get; set; }
		bool IsSubscribedToNewsletter { get; set; }
		string? Notes { get; set; }
	}

}
