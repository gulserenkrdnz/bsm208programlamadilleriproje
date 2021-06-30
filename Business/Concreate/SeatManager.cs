using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Concreate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class SeatManager : ISeatService
    {
        ISeatDal _seatDal;

        public SeatManager(ISeatDal seatDal)
        {
            _seatDal = seatDal;
        }

        public List<ReservationDetails> GetReservationDetails()
        {
            return _seatDal.GetReservationDetails();
        }

        public List<ReservationDetails> GetReservationDetailsByAgencyID(int id)
        {
            List<ReservationDetails> details = _seatDal.GetReservationDetails();
            List<ReservationDetails> result = new List<ReservationDetails>();

            foreach (var item in details)
            {
                if (item.AgencyID == id)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<Seat> GetSeatsByFlightId(int id)
        {
            return _seatDal.GetAll(s => s.FlightID == id);
        }

    }
}
