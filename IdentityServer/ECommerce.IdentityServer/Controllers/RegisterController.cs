using System.Threading.Tasks;
using ECommerce.IdentityServer.DTOs;
using ECommerce.IdentityServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            if (userRegisterDTO == null)
            {
                return BadRequest("User registration data is null.");
            }
            var user = new ApplicationUser
            {
                UserName = userRegisterDTO.Username,
                Email = userRegisterDTO.Email,
                Name = userRegisterDTO.Name,
                Surname = userRegisterDTO.Surname
            };
            var result = await _userManager.CreateAsync(user, userRegisterDTO.Password);
            if (result.Succeeded)
            {
                return Ok("User registered successfully.");
            }
            return BadRequest(result.Errors);
        }
    }
}
