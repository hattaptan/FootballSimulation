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
    public class WeekManager : IWeekService
    {

        private IWeekDal _weekDal;

        public WeekManager(IWeekDal weekDal)
        {
            _weekDal = weekDal;
        }

        public Week Add(Week fixture)
        {
            return _weekDal.Add(fixture);
        }

        public void Delete(Week fixture)
        { 
            _weekDal.Delete(fixture);
        }

        public List<Week> GetAll()
        {
            return _weekDal.GetList();
        }

        public Week GetById(int id)
        {
            return _weekDal.Get(p => p.Id == id);
        }

        public Week Update(Week fixture)
        {
            return _weekDal.Update(fixture);
        }
    }
}
