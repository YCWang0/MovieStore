using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using MovieStore.Core.Entities;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieStoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Movie>> GetHighestRatedMovies()
        {
            //var movies = await _dbContext.Reviews
            //            .Join(_dbContext.Movies,
            //            r => r.MovieId,
            //            m => m.Id,
            //            (r, m) => new { r, m }).GroupBy(x => x.r.MovieId).OrderByDescending(x => x.Key).Take(25).ToListAsync();


            //return (IEnumerable<Movie>)movies;

            var topRatedMovies = await _dbContext.Reviews.Include(m => m.Movie)
                                     .GroupBy(r => new
                                     {
                                         Id = r.MovieId,
                                         r.Movie.Title,
                                         r.Movie.Overview,
                                         r.Movie.Budget,
                                         r.Movie.Revenue,
                                         r.Movie.ImdbUrl,
                                         r.Movie.TmdbUrl,
                                         r.Movie.PosterUrl,
                                         r.Movie.BackdropUrl,
                                         r.Movie.OriginalLanguage,
                                         r.Movie.ReleaseDate,
                                         r.Movie.RunTime,
                                         r.Movie.Price,
                                         r.Movie.CreatedDate,
                                         r.Movie.UpdatedDate,
                                         r.Movie.CreatedBy,
                                         r.Movie.Tagline
                                     })
                                     .OrderByDescending(g => g.Average(m => m.Rating))
                                     .Select(m => new Movie
                                     {
                                         Id = m.Key.Id,
                                         Title = m.Key.Title,
                                         Overview = m.Key.Overview,
                                         Budget = m.Key.Budget,
                                         Revenue=m.Key.Revenue,
                                         ImdbUrl=m.Key.ImdbUrl,
                                         TmdbUrl=m.Key.TmdbUrl,
                                         PosterUrl = m.Key.PosterUrl,
                                         BackdropUrl=m.Key.BackdropUrl,
                                         OriginalLanguage=m.Key.OriginalLanguage,
                                         ReleaseDate = m.Key.ReleaseDate,
                                         RunTime=m.Key.RunTime,
                                         Price=m.Key.Price,
                                         CreatedDate=m.Key.CreatedDate,
                                         UpdatedDate=m.Key.UpdatedDate,
                                         CreatedBy=m.Key.CreatedBy,
                                         Tagline=m.Key.Tagline,
                                         Rating = m.Average(x => x.Rating)

                                     })
                                     .Take(25)
                                     .ToListAsync();
            // var topRatedMovies = await _dbContext.Movies.OrderByDescending(r => r.Reviews.Average(r => r.Rating)).Take(25).ToListAsync();
            return topRatedMovies;
        }


        public async Task<IEnumerable<Movie>> GetHighestRevenueMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(25).ToListAsync();
            // select top 25 from Movies order by Revenue desc;
            return movies;
        }



        public async Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId)
        {
            var movies = await _dbContext.MovieGenres.Where(g => g.GenreId == genreId).Include(mg => mg.Movie)
                                        .Select(m => m.Movie)
                                        .ToListAsync();
            return movies;
        }
        public async Task<decimal> GetMoviesAverageRating(int Id)
        {

            var a = await  _dbContext.Reviews.Where(r => r.MovieId == Id).AverageAsync(r => r.Rating);
            return a;
        }
        public override async Task<Movie> GetByIdAsync(int id)
        {
            var movie = await _dbContext.Movies
                                        .Include(m => m.MovieCasts).ThenInclude(m => m.Cast).Include(m => m.MovieGenres)
                                        .ThenInclude(m => m.Genre)
                                        .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null) return null;
            var movieRating = await _dbContext.Reviews.Where(r => r.MovieId == id).AverageAsync(r => r.Rating);
            if (movieRating > 0) movie.Rating = movieRating;
            return movie;
        }

    }
}
