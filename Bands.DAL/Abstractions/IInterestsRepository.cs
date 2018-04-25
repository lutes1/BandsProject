using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;

namespace Bands.DAL.Abstractions
{
    public interface IInterestsRepository : IGenericRepository<Interest>
    {
        Interest GetInterestById(long id);
        Interest GetInterestByName(string name);
        Interest CheckForStoredInterest(string interestName);
    }
}
