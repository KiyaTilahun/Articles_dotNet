using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Shared.DTOS;
using WebApplication1.UserManagement;

namespace WebApplication1.Repository
{
    public class AuthService: IAuthService
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly TokenProvider _tokenProvider;

        public AuthService(ApplicationDbContext context, UserManager<User> userManager, TokenProvider tokenProvider)
        {
            _db = context;
            _userManager = userManager;
            _tokenProvider = tokenProvider;
        }

        public async Task<string> CreateUser(RegisterUserDto dto)
        {
            var newUser = new User() { UserName = dto.UserName, Email = dto.Email, };
            var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == newUser.UserName);
       
            if (user == null)
            {
                var userCreated=await _userManager.CreateAsync(newUser, dto.Password);
                var token=_tokenProvider.Create(newUser);
                
                return token;
            }  
            return string.Empty;
        }
    }
}