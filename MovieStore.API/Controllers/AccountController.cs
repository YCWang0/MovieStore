using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Models.Request;
using MovieStore.Core.Models.Response;
using MovieStore.Core.ServiceInterfaces;
using Microsoft.IdentityModel.Tokens;
using AutoMapper.Configuration;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public AccountController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("register")]
        // http://localhost/api/account/register -- Http Post
        public async Task<IActionResult> RegisterUser([FromBody] UserRegisterRequestModel model)
        {
            // Model Binding
            // when posting json data, make sure your json keys are same as C# model proerties
            //{
            //    "firstName" : "Andy",
            //    "lastName" : "Wang",
            //    "email" : "andy.wang@gmail.com",
            //    "password":"Andy300#"
            //}
            // in MVC, name of the input in HTML should be same as C# model properties
            var user = await _userService.RegisterUser(model);
            return Ok(user);
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginUser([FromBody] UserLoginRequestModel model)
        {
            //var user = await _userService.ValidateUser(model.Email, model.Password);
            //if (user == null)
            //{
            //    ModelState.AddModelError(string.Empty, "Invalid Login");
            //}
            //var claims = new List<Claim>
            //    {
            //        new Claim(ClaimTypes.GivenName, user.FirstName),
            //        new Claim(ClaimTypes.Surname, user.LastName),
            //        new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
            //        new Claim(ClaimTypes.Name,  user.Email),
            //    };
            //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            
            //onlu when the user is valid we need to create the jwt token abd send it to client(angular,mobile,postman)

            var user = await _userService.ValidateUser(model.Email, model.Password);
            if (user == null)
            {
                return Unauthorized();
            }
            return Ok(new { token = GenerateJWT(user) });
        }
        private string GenerateJWT(UserLoginResponseModel user)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.GivenName, user.FirstName),
                    new Claim(ClaimTypes.Surname, user.LastName),
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,  user.Email),
                };
            var identityClaims = new ClaimsIdentity();
            identityClaims.AddClaims(claims);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["TokenSettings:PrivateKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var expires = DateTime.UtcNow.AddHours(_configuration.GetValue<double>("TokenSettings:ExpirationHours"));
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identityClaims,
                Expires = expires,
                SigningCredentials = credentials,
                Issuer = _configuration["TokenSettings:Issuer"],
                Audience = _configuration["TokenSettings:Audience"]
            };
            var encodedJwt = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(encodedJwt);
        }


    }
}
