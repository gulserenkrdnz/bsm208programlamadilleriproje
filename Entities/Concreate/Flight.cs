using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Flight : IEntity
    {
        public int ID { get; set; }
        public int FirmID { get; set; }
        public int DestinationCityID { get; set; }
        public int DepartureCityID { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public decimal EcoPrice { get; set; }
        public decimal BusinessPrice { get; set; }

    }
}
