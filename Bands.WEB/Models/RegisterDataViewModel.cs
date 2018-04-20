using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bands.DTO;
using Bands.WEB.Models.AccountViewModels;

namespace Bands.WEB.Models
{
    public class RegisterDataViewModel
    {
        public MusicianCommonDto MusicianCommonData { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
    }
}
