using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class BandViewModel
    {
        public string BandName { set; get; }
        public List<string> Genres { get; set; }
    }
}
