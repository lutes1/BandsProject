using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains;

namespace Bands.BLL.Abstractions
{
    public interface IBandsServices
    {
        List<Band> GetAllBands();
        Band GetBandById(long id);
    }
}
