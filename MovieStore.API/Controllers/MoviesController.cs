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
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        // we want to construct a URL for showing top 25 revenue movies
        // [Route("api/[controller]")]
        // http:localhost/api/movies/toprevenue -- GET
        // SEO , RESTFul URL's, -- should be human readable
        [HttpGet]
        [Route("toprevenue")]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetTop25HighestRevenueMovies();
            // in MVC we return Views
            // return data along with HTTP Status CODE
            //  OK -200
            if (!movies.Any())
            {
                return NotFound("No movies found");
            }
            return Ok(movies);
        }

        [HttpGet]
        [Route("toprated")]
        public async Task<IActionResult> GetTopRatedMovies()
        {
            var movies = await _movieService.GetTop25RatedMovies();
            if (!movies.Any())
            {
                return NotFound("No movies found");
            }
            return Ok(movies);
        }
        //not working
        [HttpGet]
        [Route("detail/{id:int}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _movieService.GetMovieById(id);
            return Ok(movie);
        }


        [HttpGet]
        [Route("movieCount")]
        public async Task<IActionResult> GetCountOfMovie()
        {
            var count = await _movieService.GetMovieCount();
            return Ok(count);
        }

        [HttpGet]
        [Route("genre/{genreId:int}")]
        public async Task<IActionResult> GetMoviesByGenre(int genreId)
        {
            var movies = await _movieService.GetMoviesByGenre(genreId);
            return Ok(movies);
        }


    }
}