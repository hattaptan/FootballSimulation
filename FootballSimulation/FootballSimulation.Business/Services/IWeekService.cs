using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.Business.Services
{
    public interface IWeekService
    {
        List<Week> GetAll();
        Week GetById(int id);

        Week Add(Week fixture);
        Week Update(Week fixture);
        void Delete(Week fixture);

         
    }
}
