using System.ComponentModel.DataAnnotations;

namespace Abaya_Store.Application.Model.Identity
{
	public class RegisterationRequest
	{
		[Required]
		public string FirstName { get; set; }

		[Required]

		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[MinLength(6)]
		public string UserName { get; set; }

		[Required]
		[MinLength(6)]
		public string Password { get; set; }

	}
}
