using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class InterestViewModel
    {
        public long InterestId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
    }
}
