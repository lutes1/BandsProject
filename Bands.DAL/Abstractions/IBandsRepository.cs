using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains;
using Bands.Domains.Models;

namespace Bands.DAL.Abstractions
{
    public interface IBandsRepository : IGenericRepository<Band>
    {
        Band GetBandById(long id);
    }
}
