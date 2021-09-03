using Domain.Adapters;
using Domain.Entities;
using Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClubServiceManager : IClubService
    {
        private readonly IEmailAdapter _emailAdapter;
        private readonly IClubRepository _clubRepository;

        public ClubServiceManager(IEmailAdapter emailAdapter, IClubRepository clubRepository)
        {
            _emailAdapter = emailAdapter;
            _clubRepository = clubRepository;
        }

        public async Task<Club> CreateClubAsync(Club club)
        {
            var createdClub = await _clubRepository.CreateAsync(club);
            await _emailAdapter.SendEmail(string.Empty, string.Empty, string.Empty, string.Empty);
            return createdClub;
        }

        public async Task<IEnumerable<Club>> GetAllClubsAsync()
        {
            return await _clubRepository.GetAllAsync();
        }
    }
}
