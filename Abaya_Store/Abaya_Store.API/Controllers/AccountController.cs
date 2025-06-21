using Abaya_Store.Application.Contracts.Identity;
using Abaya_Store.Application.Model.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Abaya_Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthService _authenticationService;
		public AccountController(IAuthService authenticationService)
		{
			_authenticationService = authenticationService;
		}

		[HttpPost("login")]
		public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
		{
			return Ok(await _authenticationService.Login(request));
		}

		[HttpPost("register")]
		public async Task<ActionResult<RegisterationResponse>> Register(RegisterationRequest request)
		{
			return Ok(await _authenticationService.Register  (request));
		}


	}
}
