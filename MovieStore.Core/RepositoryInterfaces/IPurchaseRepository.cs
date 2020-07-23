using MovieStore.Core.Entities;
using MovieStore.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.RepositoryInterfaces
{
    public interface IPurchaseRepository : IAsyncRepository<Purchase>
    {
        //Task<IEnumerable<Purchase>> GetAllPurchases(int pageSize = 30, int pageIndex = 0);
        //Task<IEnumerable<Purchase>> GetAllPurchasesByMovie(int movieId, int pageSize = 30, int pageIndex = 0);
        Task<IEnumerable<Movie>> GetAllMoviesPurchasedByUser(int id);
    }
}
