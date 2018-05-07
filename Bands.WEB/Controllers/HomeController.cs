using System.Collections.Generic;
using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Bands.WEB.Models;
using Bands.BLL.Abstractions;
using Bands.WEB.Models.ViewModels;

namespace Bands.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusiciansServices _musicianServices;
        private readonly IMapper _mapper;

        public HomeController(IMusiciansServices musicianServices, IBandsServices bandServices, IMapper mapper)
        {
            _musicianServices = musicianServices;
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

        public IActionResult MusicianInfo(long id)
        {
            return View(_mapper.Map<MusicianViewModel>(_musicianServices.GetMusicianById(id)));
        }

        public IActionResult Musicians(string name)
        {
            ViewData["SearchQuery"] = name;
            var model = _mapper.Map<List<MusicianViewModel>>(_musicianServices.GetMusiciansPaginated(0,name));
            if (!string.IsNullOrEmpty(name) && model.Count == 0)
                ViewData["StatusMessage"] = "There aren't any musicians with this name"; 
            return View(model);
        }

        public IActionResult MusiciansPage(int pageNumber, string name)
        {
            var model = _mapper.Map<List<MusicianViewModel>>(_musicianServices.GetMusiciansPaginated(pageNumber, name));
            return PartialView("MusicianPage",model);
        }
    }
}