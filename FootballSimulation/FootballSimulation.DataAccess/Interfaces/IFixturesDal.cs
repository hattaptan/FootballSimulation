using FootballSimulation.Base.DataAccessLayer.Interfaces;
using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.DataAccess.Interfaces
{
    public interface IFixturesDal : IEntityRepository<Fixture>
    {
        List<Fixture> Paging(int skip, int take);

    }
}
