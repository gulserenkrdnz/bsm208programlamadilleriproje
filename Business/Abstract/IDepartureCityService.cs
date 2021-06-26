using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDepartureCityService
    {
        List<DepartureCity> GetAll();
        DepartureCity GetById(int id);
        DepartureCity GetByName(string cityName);
    }
}
