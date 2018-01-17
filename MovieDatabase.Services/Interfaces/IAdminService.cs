namespace MovieDatabase.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IAdminService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<IEnumerable<Movie>> GetAllMoviesAsync();

        Task<IEnumerable<Actor>> GetAllActorsAsync();
    }
}
