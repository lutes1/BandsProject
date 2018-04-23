using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Bands.DTO;
using Bands.WEB.Models.AccountViewModels;

namespace Bands.WEB.Models
{
    public class RegisterDataViewModel
    {
        public MusicianReadCommonDto MusicianReadCommonData { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
        public Microsoft.AspNetCore.Identity.IdentityResult Result { get; set; }
    }
}
