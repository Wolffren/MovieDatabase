namespace MovieDatabase.Web.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Entities.Models.Actor;
    using Entities.Models.Movie;
    using Entities.Models.User;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services.Interfaces;

    //[Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IAdminService _service;
        private readonly IMapper _mapper;

        public HomeController(IAdminService service,IMapper mapper)
        {
            this._service = service;
            this._mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.UsersCount = await this._service.GetUsersCountAsync();
            ViewBag.MoviesCount = await this._service.GetMoviesCountAsync();
            ViewBag.ActorsCount = await this._service.GetActorsCountAsync();
            return View();
        }

        public async Task<IActionResult> Users()
        {
            var users =  await this._service.GetAllUsersAsync();

            var viewModel = this._mapper.Map<IEnumerable<UserVm>>(users);

            return View(viewModel);
        }


        public async Task<IActionResult> Movies()
        {
            var movies = await this._service.GetAllMoviesAsync();

            var viewModel = this._mapper.Map<IEnumerable<MovieVm>>(movies);

            return View(viewModel);
        }

        public async Task<IActionResult> Actors()
        {
            var actors = await this._service.GetAllActorsAsync();

            var viewModel = this._mapper.Map<IEnumerable<ActorVm>>(actors);

            return View(viewModel);
        }
    }
}