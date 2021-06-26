using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Seat : IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int FlightID { get; set; }
        public int SeatNo { get; set; }
        public bool IsAvailable { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }


    }
}
