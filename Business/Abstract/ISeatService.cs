using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISeatService
    {
        List<Seat> GetSeatsByFlightId(int id);
    }
}
