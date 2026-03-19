using MarketBackend.AuthService.DTOs;

namespace MarketBackend.AuthService.Services
{
    public interface IAuthService
    {
        Task<string> Register(UserRegisterDto dto);
        Task<string> Login(UserRegisterDto dto);
    }
}
