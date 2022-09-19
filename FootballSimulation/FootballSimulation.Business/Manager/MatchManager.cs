using FootballSimulation.Business.Services;
using FootballSimulation.DataAccess.Interfaces;
using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.Business.Manager
{
    public class MatchManager : IMatchService
    {

        private IMatchDal _matchDal;

        public MatchManager(IMatchDal matchDal)
        {
            _matchDal = matchDal;
        }



        public Match Add(Match fixture)
        {
            return _matchDal.Add(fixture);
        }

        public void Delete(Match fixture)
        {
            _matchDal.Delete(fixture);
        }

        public List<Match> GetAll()
        {
            return _matchDal.GetList();
        }

         
         

        public Match Update(Match fixture)
        {
            return _matchDal.Update(fixture);
        }
    }
}
