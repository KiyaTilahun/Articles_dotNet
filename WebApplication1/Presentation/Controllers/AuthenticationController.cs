using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Contracts;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Shared.DTOS;

namespace WebApplication1.Presentation.Controllers
{
    
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController:ControllerBase
    {
        private readonly IAuthService _service;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        public AuthenticationController(ApplicationDbContext dbContext,UserManager<User> userManager,IAuthService service)
        {
            _service = service;
            _context = dbContext;
            _userManager = userManager;
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> registerUser([FromBody] RegisterUserDto dto, IValidator<RegisterUserDto> validator)
        {
            var validationResult =  validator.Validate(dto);

            if (!validationResult.IsValid)
            {
                var errorsDictionary = validationResult.Errors
                    .GroupBy(x => x.PropertyName)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(x => x.ErrorMessage).ToArray()
                    );

                var problemDetails = new HttpValidationProblemDetails(errorsDictionary)
                {
                    Status = StatusCodes.Status422UnprocessableEntity,
                    Title = "Validation Error",
                    Detail = "One or more validation errors occurred.",
                    Instance = HttpContext.Request.Path
                };

                return UnprocessableEntity(problemDetails);
            }


            var token=await _service.CreateUser(dto);
            return Ok(token );
        }
     
    }
}