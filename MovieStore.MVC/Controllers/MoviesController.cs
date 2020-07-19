//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using MovieStore.MVC.Models;

//namespace MovieStore.MVC.Controllers
//{
//    //get localhost/movies/index

//    public class MoviesController : Controller
//    {
//        [HttpGet]
//        public IActionResult Index()
//        {
//            var movies = new List<Movie>
//            {
//            //    new Movie {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
//            //    new Movie {Id = 2, Title = "Avatar", Budget = 1200000},
//            //    new Movie {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
//            //    new Movie {Id = 4, Title = "Titanic", Budget = 1200000},
//            //    new Movie {Id = 5, Title = "Inception", Budget = 1200000},
//            //    new Movie {Id = 6, Title = "Avengers: Age of Ultron", Budget = 1200000},
//            //    new Movie {Id = 7, Title = "Interstellar", Budget = 1200000},
//            //    new Movie {Id = 8, Title = "Fight Club", Budget = 1200000},
//            //};
//            ////way2
//            //ViewBag.MoviesCount = movies.Count;
//            ////way 3
//            ViewData["myname"] = "John Doe";
//            // compile time checks vs run-time checks
//            // we need to pass data from Controller action method to the View
//            // Usually its preferred to send a strongly typed Model or object to the view
//            // 3 ways to send data from Controller to View
//            // 1. Strongly-typed models (preferred way)
//            // 2. ViewBag --dynamic
//            // 3. ViewData - key/value
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Create(string title, decimal budget)
//        {
//            //POST http:localhost/movies/create

//            //Model binding case in-sensitive 
//            //look at incoming request and maps the input elements name/value with the paramater names of the action method
//            //then the paramater will have the value aumatically
//            //it will also does casting/converting(map the form name = paramaterName) pass as paramater 
//            //
//            // we need to get the data from the view and save it in database
//            return View();
//        }
//        [HttpGet]
//        public IActionResult Create()
//        {
//            // GET http:localhost/movies/create
//            // we need to have this method so that we can show the empty page for user to enter movie info that need to be created
//            return View();
//        }

//    }
//}
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;

using MovieStore.Core.ServiceInterfaces;
using MovieStore.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieStore.MVC.Controllers
{
    public class MoviesController : Controller
    {
        // IOC, ASP.NET Core has built-in IOC/DI
        // In .NET Framework we need to to rely on third-party IOC to do Dependency Injection, Autofac, Ninject
        private readonly IMovieService _movieService;
        private readonly ICastService _castService;
        private readonly IGenreService _genreService;
        public MoviesController(IMovieService movieService,ICastService castService,IGenreService genreService)
        {
            _movieService = movieService;
            _castService = castService;
            _genreService = genreService;
        }
        //  GET localhost/Movies/index
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // call our Movie Service ,method, highest grossing method
            var movies = await _movieService.GetTop25HighestRevenueMovies();
            return View(movies);
        }

        
        
        [HttpGet]
        public async Task<IActionResult> Genres(int genreId)
        { 
            var movies = await _movieService.GetMoviesByGenre(genreId);
            return View(movies);
        }
        
        [HttpGet]
        public async Task<IActionResult> Detail(int Id)
        {
            
            var movie = await _movieService.GetMovieById(Id);
            var cast = await _castService.GetAllCastsByMovieId(Id);
            var rat = await _movieService.GetMoviesAverageRating(Id);
            var genre = await _genreService.GetGenresByMovieId(Id);
            var d = new Detail()
            {
                DetailMovie = movie,
                DetailCast = cast,
                DetailRating = rat,
                DetailGenre = genre
            };
            return View(d);
        }

        
    }
}