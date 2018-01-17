using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Web.Extensions
{
    using AutoMapper;
    using Entities;
    using Entities.Models.User;

    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<User, UserVm>();
        }        
    }
}
