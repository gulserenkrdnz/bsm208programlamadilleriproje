using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate.DTOs
{
    public class ReservationDetails : IDto
    {
        public int ReservationID { get; set; }
        public int AgencyID { get; set; }
        public int UserID { get; set; }
        public string FirmName { get; set; }
        public int SeatNo { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Price { get; set; }
    }
}
