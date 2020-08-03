using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Models.Response
{
    public class FavoriteResponseModel
    {
        public int UserId { get; set; }
        public List<FavoriteMovieResponseModel> FavoriteMovies { get; set; }
        public class FavoriteMovieResponseModel : MovieResponseModel
        {
        }
    }
}
