using FootballSimulation.Business.Services;
using FootballSimulation.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballSimulation.API1.Controllers
{
   
    [ApiController]
    public class WeekController : ControllerBase
    {
        private IWeekService _weekService;

        public WeekController(IWeekService weekService)
        {
            _weekService = weekService;
        }


        /// <summary>
        /// Get All Week
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/week/getall")]
        public List<Week> GetAll()
        {
            return _weekService.GetAll();
        }

        /// <summary>
        /// Add Week
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/week/add")]
        public IActionResult Add()
        {
              _weekService.Add(new Week
            {
                Id = 0,
                WeekNo = "Week 2"



            });
            _weekService.Add(new Week
            {
                Id = 0,
                WeekNo = "Week 3"



            });
            _weekService.Add(new Week
            {
                Id = 0,
                WeekNo = "Week 4"



            });
            _weekService.Add(new Week
            {
                Id = 0,
                WeekNo = "Week 5"



            });
            _weekService.Add(new Week
            {
                Id = 0,
                WeekNo = "Week 6"



            });
            _weekService.Add(new Week
            {
                Id = 0,
                WeekNo = "Week 7"



            });

            return Ok("Weeks Added Successfuly");
        }



    }
}
