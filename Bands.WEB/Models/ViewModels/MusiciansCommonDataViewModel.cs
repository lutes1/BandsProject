using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bands.WEB.Models.ViewModels
{
    public class MusiciansCommonDataViewModel
    {
        public List<SelectListItem> SelectListCities { get; set; }
        public List<SelectListItem> SelectListMusicianTypes { get; set; }
        public List<SelectListItem> SelectListCountry { get; set; }
        public List<SelectListItem> SelectListInterests { get; set; }

        public MusiciansCommonDataViewModel()
        {
            SelectListCities = new List<SelectListItem>();
            SelectListCountry = new List<SelectListItem>();
            SelectListInterests = new List<SelectListItem>();
            SelectListMusicianTypes = new List<SelectListItem>();
        }
    }
}
