using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate.DTOs
{
    public class FlightListElement : IDto
    {
        public String FirmName { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public decimal EcoPrice { get; set; }
        public decimal BusinessPrice { get; set; }
    }
}
