using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.Business.Services
{
    public interface IMatchService
    {
        List<Match> GetAll();
      
        Match Add(Match fixture);
        Match Update(Match fixture);
        void Delete(Match fixture);
         
        
    }
}
