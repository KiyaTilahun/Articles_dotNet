using WebApplication1.Shared.DTOS;

namespace WebApplication1.Contracts
{
    public interface IAuthService
    {
        Task<string> CreateUser(RegisterUserDto user);
    }
}