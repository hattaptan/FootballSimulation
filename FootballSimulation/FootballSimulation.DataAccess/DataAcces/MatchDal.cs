using FootballSimulation.Base.DataAccessLayer.Manager;
using FootballSimulation.DataAccess.Context;
using FootballSimulation.DataAccess.Interfaces;
using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.DataAccess.DataAcces
{
    public class MatchDal  : EntityRepository<Match, FootballSimulationContext>, IMatchDal
    {
    }
}
