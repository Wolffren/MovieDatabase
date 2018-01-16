using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieDatabase.Web.Areas.Admin.Controllers
{
    using Services.Interfaces;

    public class HomeController : Controller
    {
        private readonly IAdminService _service;

        public HomeController(IAdminService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            var users =  this._service.GetAllUsers();

            return View(users);
        }
    }
}