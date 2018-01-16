using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabase.Services
{
    using System.Collections;
    using System.Threading.Tasks;
    using AutoMapper;
    using Data;
    using Entities;
    using Interfaces;
    using Microsoft.AspNetCore.Identity;
    using Models.User;

    public class AdminService : IAdminService
    {
        private readonly MovieDatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        public AdminService(MovieDatabaseContext context, IMapper mapper, UserManager<User> userManger)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManger;
        }

        public IEnumerable<UserVm> GetAllUsers()
        {
            var users = new List<User>();
            foreach (var user in this._userManager.Users)
            {
                users.Add(user);
            }

            var result = this._mapper.Map<IEnumerable<UserVm>>(users);
            return result;
        }
    }
}
