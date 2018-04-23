using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bands.DAL.Abstractions;
using Bands.Domains.Models;

namespace Bands.DAL.Repositories
{
    public class InterestsRepository : DatabaseRepository<Interest>, IInterestsRepository
    {
        public InterestsRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Interest GetInterestById(long id)
        {
            return DbContext.Interests.FirstOrDefault(x => x.InterestId == id);
        }

        public Interest GetInterestByName(string name)
        {
            return DbContext.Interests.FirstOrDefault(x => x.Name == name);
        }
    }
}
