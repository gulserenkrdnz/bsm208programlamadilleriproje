using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    class EfDepartureCityDal : EfEntityRepositoryBase<DepartureCity, FlightReservationContext>, IDepartureCityDal
    {
    }
}
