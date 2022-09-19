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
    public class FixtureManager : IFixtureService
    {
        private IFixturesDal _fixtureDal;

        public FixtureManager(IFixturesDal fixtureDal)
        {
            _fixtureDal = fixtureDal;
        }

        public Fixture Add(Fixture fixture)
        {
            return _fixtureDal.Add(fixture);
        }

        public void Delete(Fixture fixture)
        {
            _fixtureDal.Delete(fixture);
        }

        public List<Fixture> GetAll()
        {
            return _fixtureDal.GetList();
        }

        public Fixture GetById(int id)
        {
            return _fixtureDal.Get(p => p.Id == id);
        }

        public List<Fixture> GetFixtureById(int id)
        {
            return _fixtureDal.GetList(p=>p.Week.Id == id);
        }

        

        public List<Fixture> Paging(int skip, int take)
        {
            return _fixtureDal.Paging(skip, take);
        }

        public Fixture Update(Fixture fixture)
        {
            return _fixtureDal.Update(fixture);

        }
    }
}
