using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Concreate.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfFlightDal : EfEntityRepositoryBase<Flight, FlightReservationContext>, IFlightDal
    {
        public List<FlightListElement> GetFlightDetails()
        {
            using (FlightReservationContext context = new FlightReservationContext())
            {
                var result = from fligth in context.Flights
                             join Depcity in context.DepartureCity
                             on fligth.DepartureCityID equals Depcity.ID
                             join Descity in context.DestinationCity
                             on fligth.DestinationCityID equals Descity.ID
                             join firm in context.Firms
                             on fligth.FirmID equals firm.ID
                             select new FlightListElement
                             {
                                 FlightID = fligth.ID,
                                 FirmName = firm.FirmName,
                                 DepartureCity = Depcity.CityName,
                                 DestinationCity = Descity.CityName,
                                 DepartureDate = fligth.DepartureDate,
                                 DepartureTime = fligth.DepartureTime,
                                 ArrivalTime = fligth.ArrivalTime,
                                 EcoPrice = fligth.EcoPrice,
                                 BusinessPrice = fligth.BusinessPrice
                             };
                return result.ToList();
            }
        }
    }
}
