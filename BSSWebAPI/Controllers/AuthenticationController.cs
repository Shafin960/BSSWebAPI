using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Core.Models;
using Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BSSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IConfiguration _config;
        private readonly UserManager<ApplicationUser> userManager;
        public AuthenticationController(IConfiguration config, UserManager<ApplicationUser> userManager)
        {
            _config = config;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<string> Login([FromBody] UserLogin userLogin)
        {
            var user = await userManager.FindByNameAsync(userLogin.UserName) ?? throw new Exception("User not found");
            var result = await userManager.CheckPasswordAsync(user, userLogin.Password);
            if (result)
            {
                return Generate(user);
            }
            throw new Exception("User not found");
        }

        private string Generate(ApplicationUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials= new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
