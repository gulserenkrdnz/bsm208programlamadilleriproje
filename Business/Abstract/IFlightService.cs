using Entities.Concreate;
using Entities.Concreate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IFlightService 
    {
        List<Flight> GetAll();
        List<Flight> GetAllByFlightId(int id);
        List<Flight> GetAllByFirmId(int id);
        List<Flight> GetAllByEcoPrice(decimal min, decimal max);
        List<Flight> GetAllByBusinessPrice(decimal min, decimal max);
        List<Flight> GetAllByCityId (int departureCity, int destinationCity);
        void Add(Flight flight);
        List<FlightListElement> GetFlightDetails();
    }
}
