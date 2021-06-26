using Core.DataAccess;
using Entities.Concreate;
using Entities.Concreate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IFlightDal : IEntityRepository<Flight>
    {
        public List<FlightListElement> GetFlightDetails();
    }
}
