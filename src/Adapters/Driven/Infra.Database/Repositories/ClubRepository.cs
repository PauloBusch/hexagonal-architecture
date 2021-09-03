using Domain.Adapters;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Database.Repositories
{
    public class ClubRepository : IClubRepository
    {
        public Task<Club> CreateAsync(Club club)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
