using FootballSimulation.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballSimulation.API1.Controllers
{
     
    [ApiController]
    public class FixtureController : ControllerBase
    {
        private IFixtureService _fixtureService;
        private IWeekService _weekService;
        private ITeamService _teamService;
        public FixtureController(IFixtureService fixtureService, IWeekService weekService , ITeamService teamService)
        {
            _fixtureService = fixtureService;
            _weekService = weekService;
            _teamService = teamService;
        }
        /// <summary>
        /// Add Fixtrue
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/fixture/add")]
        public IActionResult Add()
        {
            var week = _weekService.GetById(2);
            var team = _teamService.GetById(2);
            var team2 = _teamService.GetById(3);




            var add = _fixtureService.Add(new Entities.Entities.Fixture
            {
                Id = 0,
                HomeTeam=team,
                Week=week,
                OpponentTeam=team2,
                
                
            });

            return Ok(add);

        }
        /// <summary>
        /// Get All Fixture
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/fixture/getall")]
        public IActionResult GetAll()
        {
             var getAll = _fixtureService.GetAll();
            return Ok(getAll);

        }

         

    }
}
