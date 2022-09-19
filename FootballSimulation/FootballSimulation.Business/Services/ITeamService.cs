using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.Business.Services
{
    public interface ITeamService
    {
        List<Team> GetAll();
        Team GetById(int id);
        Team Add(Team fixture);
        Team Update(Team fixture);
        void Delete(Team fixture);

       
    }
}
