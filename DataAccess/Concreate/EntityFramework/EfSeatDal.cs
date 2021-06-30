using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Concreate.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfSeatDal : EfEntityRepositoryBase<Seat, FlightReservationContext>, ISeatDal
    {
        public List<ReservationDetails> GetReservationDetails()
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
                             join seat in context.Seats
                             on fligth.ID equals seat.FlightID
                             join reserv in context.Reservation
                             on seat.ID equals reserv.SeatID
                             join agency in context.Agencies
                             on reserv.AgencyID equals agency.ID
                             join user in context.Users
                             on seat.UserID equals user.ID
                             select new ReservationDetails
                             {
                                 ReservationID = reserv.ID,
                                 AgencyID = agency.ID,
                                 UserID = user.ID,
                                 FirmName = firm.FirmName,
                                 SeatNo = seat.SeatNo,
                                 DepartureCity = Depcity.CityName,
                                 DestinationCity = Descity.CityName,
                                 DepartureDate =fligth.DepartureDate,
                                 DepartureTime = fligth.DepartureTime,
                                 ArrivalTime = fligth.ArrivalTime,
                                 Name = seat.Name,
                                 LastName = seat.LastName,
                                 Price = fligth.EcoPrice
                             };
                return result.ToList();
            }
        }
    }
}
