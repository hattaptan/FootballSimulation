using FootballSimulation.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.Business.Services
{
    public interface IFixtureService 
    {
        List<Fixture> GetAll();
        Fixture GetById(int id);
        Fixture Add (Fixture fixture);
        Fixture Update(Fixture fixture);
        void Delete(Fixture fixture);

        List<Fixture> Paging(int skip, int take);


    }
}
