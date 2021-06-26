using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class DestinationCityManager : IDestinationCityService
    {
        IDestinationCityDal _cityDal;

        public DestinationCityManager(IDestinationCityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<DestinationCity> GetAll()
        {
            return _cityDal.GetAll();
        }

        public DestinationCity GetById(int id)
        {
            return _cityDal.Get(u => u.ID == id);
        }

        public DestinationCity GetByName(string cityName)
        {
            return _cityDal.Get(u => u.CityName == cityName);
        }
    }
}
