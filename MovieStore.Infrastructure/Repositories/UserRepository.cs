﻿using Microsoft.EntityFrameworkCore;
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
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(MovieStoreDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _dbContext.users.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<IEnumerable<Movie>> GetAllFavoritesByUser(int id)
        {
            return await _dbContext.Favorites.Where(i => i.UserId == id).Select(m => m.Movie).ToListAsync();
        }
    }
}
