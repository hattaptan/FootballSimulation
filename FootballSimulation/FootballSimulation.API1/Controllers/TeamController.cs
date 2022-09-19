using FootballSimulation.Business.Services;
using FootballSimulation.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballSimulation.API1.Controllers
{
    
    [ApiController]
    public class TeamController : ControllerBase
    {
        private ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }



        /// <summary>
        /// Get All Team
        /// </summary>
        /// <returns></returns>

        [HttpGet("api/team/getall")]
        public List<Team> GetAll()
        {
            return _teamService.GetAll();
        }

        /// <summary>
        /// Add Team
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/team/add")]
        public IActionResult Add()
        {
            _teamService.Add(new Team
            {
                Id = 0,
                TeamName  = "Team 1"



            });
            _teamService.Add(new Team
            {
                Id = 0,
                TeamName = "Team 2"



            });
            _teamService.Add(new Team
            {
                Id = 0,
                TeamName = "Team 3"



            });
            _teamService.Add(new Team
            {
                Id = 0,
                TeamName = "Team 4"



            });
            _teamService.Add(new Team
            {
                Id = 0,
                TeamName = "Team 5"



            });
            _teamService.Add(new Team
            {
                Id = 0,
                TeamName = "Team 6"



            });
            _teamService.Add(new Team
            {
                Id = 0,
                TeamName = "Team 7"



            });

            return Ok("Teams Added Successfuly");
        }


    }
}
