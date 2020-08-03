using Microsoft.AspNetCore.Http;
using MovieStore.Core.Models.Response;
using MovieStore.Core.Entities;

using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace MovieStore.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ICastRepository _castRepository;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        // Constructor Injection, inject MovieRepository class instance
        public MovieService(IMovieRepository movieRepository, ICastRepository castRepository, IUserService userService,IMapper mapper)
        {
            _movieRepository = movieRepository;
            _castRepository = castRepository;
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Movie>> GetTop25HighestRevenueMovies()
        {
            //getHighestRevenueMovies actuall get top 25
            return  await _movieRepository.GetHighestRevenueMovies();
        }

        public async Task<IEnumerable<Movie>> GetTop25RatedMovies()
        {
            //GetHighestRatedMovies actuall get top 25
            return await _movieRepository.GetHighestRatedMovies();
        }

        public async Task<Movie> GetMovieById(int id)
        {
            //use instance of movieRepo to get movie   
            return await _movieRepository.GetByIdAsync(id);
        }
        //*********************
        //for the api
       
        public async Task<Movie> CreateMovie(Movie movie)
        {
            //use instance of movieRepo to creare movie
            return await _movieRepository.AddAsync(movie);
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            //use instance of movieRepo to update movie
            return await _movieRepository.UpdateAsync(movie);
        }

        public async Task<int> GetMovieCount(string title = "")
        {
            if (string.IsNullOrEmpty(title))//check if title is null or not 
            {
                return await _movieRepository.GetCountAsync();//if  title is null not passing the title 
            }
            //title not null using instance of movierepo to call getcountAsync, since we already implement it in the EfRepo class
            return await _movieRepository.GetCountAsync(m => m.Title.Contains(title));
        }

        public async Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId)
        {
            return await _movieRepository.GetMoviesByGenre(genreId);
        }

        public async Task<decimal> GetMoviesAverageRating(int Id)
        {
            return await _movieRepository.GetMoviesAverageRating(Id);
        }

        public async Task<IEnumerable<Cast>> GetAllCastsByMovieId(int id)
        {
           return await _castRepository.GetAllCastsByMovieId(id);
        }

        public async Task<MovieDetailsResponseModel> GetMovieAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            //if (movie == null) throw new NotFoundException("Movie", id);
            var favoritesCount = 0;
            var response = _mapper.Map<MovieDetailsResponseModel>(movie);
            response.FavoritesCount = favoritesCount;


            //var response = new MovieDetailsResponseModel()
            //{
            //    Id = movie.Id,
            //    Title = movie.Title,
            //    PosterUrl = movie.PosterUrl,
            //    BackdropUrl = movie.BackdropUrl,
            //    Rating = movie.Rating,
            //    Overview = movie.Overview,
            //    Tagline = movie.Tagline,
            //    Budget = movie.Budget,
            //    Revenue = movie.Revenue,
            //    ImdbUrl = movie.ImdbUrl,
            //    ReleaseDate = movie.ReleaseDate,
            //    RunTime = movie.RunTime,
            //    Price = movie.Price
            //};
            return response;
        }
    }

}
