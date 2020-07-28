using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMovieService _MovieService;
        public HomeController(IMovieService movieService)
        {
            _MovieService = movieService;
        }
        [HttpGet]
        [Route("homepage")]
        public async Task<IActionResult> GetHomePage()
        {
            var movies = await _MovieService.GetTop25HighestRevenueMovies();
            return Ok(movies);
        }
    }
}
