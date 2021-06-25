using Business.Abstract;
using DataAccess.Abstract;
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
    }
}
