using Microsoft.EntityFrameworkCore;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Response;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Infrastructure.Repositories
{
    public class PurchaseRepository: EfRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(MovieStoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesPurchasedByUser(int id)
        {
            return await _dbContext.Purchases.Where(i=>i.UserId==id).Select(m=>m.Movie).ToListAsync();
        }
    }
}
