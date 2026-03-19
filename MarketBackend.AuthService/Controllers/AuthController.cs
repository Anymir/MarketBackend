using Microsoft.AspNetCore.Mvc;
using MarketBackend.AuthService.DTOs;
using MarketBackend.AuthService.Services;

namespace MarketBackend.AuthService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(UserRegisterDto dto)
        {
            var result = await _authService.Register(dto);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserRegisterDto dto)
        {
            var token = await _authService.Login(dto);
            return Ok(token);
        }
    }
}
