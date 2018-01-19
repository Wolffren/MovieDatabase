namespace MovieDatabase.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data;
    using Entities;
    using Interfaces;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class AdminService : IAdminService
    {
        private readonly MovieDatabaseContext _context;
        private readonly UserManager<User> _userManager;

        public AdminService(MovieDatabaseContext context, UserManager<User> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await this._userManager.Users.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await this._context.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllActorsAsync()
        {
            return await this._context.Actors.ToListAsync();
        }

        public async Task<int> GetUsersCountAsync()
        {
            return await this._userManager.Users.CountAsync();
        }

        public async Task<int> GetMoviesCountAsync()
        {
            return await this._context.Movies.CountAsync();
        }

        public async Task<int> GetActorsCountAsync()
        {
            return await this._context.Actors.CountAsync();
        }
    }
}
