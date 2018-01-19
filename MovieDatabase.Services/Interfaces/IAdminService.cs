namespace MovieDatabase.Services.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IAdminService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<int> GetUsersCountAsync();

        Task<IEnumerable<Movie>> GetAllMoviesAsync();

        Task<int> GetMoviesCountAsync();

        Task<IEnumerable<Actor>> GetAllActorsAsync();

        Task<int> GetActorsCountAsync();


    }
}
