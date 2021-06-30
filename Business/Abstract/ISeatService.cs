using Entities.Concreate;
using Entities.Concreate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISeatService
    {
        List<Seat> GetSeatsByFlightId(int id);
        List<ReservationDetails> GetReservationDetails();
        List<ReservationDetails> GetReservationDetailsByAgencyID(int id);
    }
}
