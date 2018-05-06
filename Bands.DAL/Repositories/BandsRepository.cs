using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bands.DAL.Abstractions;
using Bands.Domains;
using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace Bands.DAL.Repositories
{
    public class BandsRepository : DatabaseRepository<Band>, IBandsRepository
    {
        public BandsRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Band> GetAllBands()
        {
            return DbContext.Bands
                .Include(x=>x.BandsGenres)
                .Include(x=>x.Picture)
                .ToList();
        }

        public Band GetBandById(long id)
        {
            return DbContext.Bands
                .Include(x => x.BandsGenres)
                .Include(x => x.Picture)
                .FirstOrDefault(x=>x.BandId == id);
        }
    }
}