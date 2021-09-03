using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        [HttpGet]
        public async Task<IEnumerable<Club>> GetAsync()
        {
            return await _clubService.GetAllClubsAsync();
        }

        [HttpPost]
        public async Task<Club> PostAsync([FromBody] Club club)
        {
            return await _clubService.CreateClubAsync(club);
        }
    }
}
