using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Bands.WEB.Models;
using Bands.BLL;
using Bands.BLL.Abstractions;
using Bands.WEB.Models.ViewModels;

namespace Bands.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusiciansServices _musicianServices;
        private readonly IBandsServices _bandServices;
        private readonly IMapper _mapper;

        public HomeController(IMusiciansServices musicianServices,IBandsServices bandServices,IMapper mapper)
        {
            _musicianServices = musicianServices;
            _bandServices = bandServices;
            _mapper = mapper;
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

        public IActionResult MusicianPage(long id)
        {
            return View(_mapper.Map<MusicianViewModel>(_musicianServices.GetMusicianById(id)));
        }

        public IActionResult Musicians()
        {
            var musicianread = _musicianServices.GetMusicianById(4);
            var model = Mapper.Map<List<MusicianViewModel>>(_musicianServices.GetAllMusicians());
            return View(model);
        }
    }
}