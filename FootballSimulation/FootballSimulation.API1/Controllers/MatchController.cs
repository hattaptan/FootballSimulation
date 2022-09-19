using FootballSimulation.Business.Services;
using FootballSimulation.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 

namespace FootballSimulation.API1.Controllers
{
   
    [ApiController]
    public class MatchController : ControllerBase
    { 
        private IMatchService _matchService;
        private IFixtureService _fixtureService;
 

        public MatchController(IMatchService MatchService, IFixtureService fixtureService)
        {
            _matchService = MatchService;
            _fixtureService = fixtureService;
        }
        /// <summary>
        /// Get All Match
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/match/getall")]
        public IActionResult GetAll()
        {
            var getAll = _matchService.GetAll();
            return Ok(getAll);

        }

        /// <summary>
        /// Add Match
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/match/add")]
        public IActionResult Add()
        {
            var fixture = _fixtureService.GetById(1);
          


            _matchService.Add(new Match
            {
                Id = 0,
                FixtureId = fixture.Id,
                ConcededGoal = 2,
                ScoredGoal=4,
                Score = 3,


            }); ;

            return Ok("Matchs Added Successfuly");
        }
 

    }
}
