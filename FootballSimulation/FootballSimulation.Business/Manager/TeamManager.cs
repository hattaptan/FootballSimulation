using FootballSimulation.Business.Services;
using FootballSimulation.DataAccess;
using FootballSimulation.DataAccess.Interfaces;
using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.Business.Manager
{
    public class TeamManager : ITeamService
    {

        private ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public Team Add(Team fixture)
        {
           return _teamDal.Add(fixture);
        }

        public void Delete(Team fixture)
        {
            _teamDal.Delete(fixture);
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetList();
        }

        public Team GetById(int id)
        {
            return _teamDal.Get(p=>p.Id == id);
        }

        public Team Update(Team fixture)
        {
            return _teamDal.Update(fixture);
        }
    }
}
