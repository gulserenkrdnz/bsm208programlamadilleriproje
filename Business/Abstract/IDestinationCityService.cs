using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDestinationCityService
    {
        List<DestinationCity> GetAll();
        DestinationCity GetById(int id);
        DestinationCity GetByName(string cityName);
    }
}
