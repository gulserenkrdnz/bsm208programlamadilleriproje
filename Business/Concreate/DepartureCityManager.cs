using Business.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace Business.Concreate
{
    public class DepartureCityManager : IDepartureCityService
    {
        IDepartureCityDal _cityDal;

        public DepartureCityManager(IDepartureCityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<DepartureCity> GetAll()
        {
            return _cityDal.GetAll();
        }

        public DepartureCity GetById(int id)
        {
            return _cityDal.Get(u => u.ID == id);
        }

        public DepartureCity GetByName(string cityName)
        {
            return _cityDal.Get(u => u.CityName == cityName);
        }
    }
}
