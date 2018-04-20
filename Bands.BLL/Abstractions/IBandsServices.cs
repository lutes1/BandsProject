using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains;
using Bands.Domains.Models;

namespace Bands.BLL.Abstractions
{
    public interface IBandsServices
    {
        List<Band> GetAllBands();
        Band GetBandById(long id);
    }
}
