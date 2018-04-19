using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bands.WEB.Models;
using Bands.BLL;
using Bands.BLL.Abstractions;

namespace Bands.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusiciansServices _musicianServices;
        private readonly IBandsServices _bandServices;

        public HomeController(IMusiciansServices musicianServices,IBandsServices bandServices)
        {
            _musicianServices = musicianServices;
            _bandServices = bandServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Bands()
        {
            var model = _bandServices.GetAllBands();
            return View(model);
        }

        public IActionResult Musicians()
        {
            var model = _musicianServices.GetAllMusicians();
            return View(model);
        }
    }
}
