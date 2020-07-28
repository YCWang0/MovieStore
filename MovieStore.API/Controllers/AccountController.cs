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
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
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
            var user = await _userService.ValidateUser(model.Email, model.Password);
            if (user == null) return Unauthorized();
            return Ok(user);
        }



    }
}
