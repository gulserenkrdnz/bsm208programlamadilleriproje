using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class FlightManager : IFlightService
    {
        IFlightDal _flightDal;

        public FlightManager(IFlightDal flightDal)
        {
            _flightDal = flightDal;
        }

        public void Add(Flight flight)
        {
            _flightDal.Add(flight);

        }

        public List<Flight> GetAll()
        {
            return _flightDal.GetAll();

        }

        public List<Flight> GetAllByBusinessPrice(decimal min, decimal max)
        {
            return _flightDal.GetAll(f => f.BusinessPrice >= min && f.BusinessPrice <= max);
        }

        public List<Flight> GetAllByEcoPrice(decimal min, decimal max)
        {
            return _flightDal.GetAll(f => f.EcoPrice >= min && f.EcoPrice <= max);
        }

        public List<Flight> GetAllByFirmId(int id)
        {
            return _flightDal.GetAll(f => f.FirmID == id);
        }

        public List<Flight> GetAllByFlightId(int id)
        {
            return _flightDal.GetAll(f => f.ID == id);
        }
    }
}
