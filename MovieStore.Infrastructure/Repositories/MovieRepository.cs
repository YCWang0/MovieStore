﻿using Microsoft.EntityFrameworkCore;
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
            var movies = await _dbContext.Reviews
                        .Join(_dbContext.Movies,
                        r => r.MovieId,
                        m => m.Id,
                        (r, m) => new { r, m }).GroupBy(x => x.r.MovieId).OrderByDescending(x=>x.Key).Take(25).ToListAsync();


            return (IEnumerable<Movie>)movies;
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
        //public override async Task<IEnumerable<Cast>> ListAsync(int movieId)
        //{
        //    var casts = await _dbContext.MovieCasts.Where(m => m.MovieId == movieId).Include(mc => mc.Cast)
        //                .Select(c => c.Cast)
        //                .ToListAsync();
        //    return casts;
        //}

    }
}
