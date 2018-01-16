using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabase.Services.Interfaces
{
    using System.Threading.Tasks;
    using Models.User;

    public interface IAdminService
    {
        IEnumerable<UserVm> GetAllUsers();
    }
}
