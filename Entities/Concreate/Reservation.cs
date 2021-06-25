using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Reservation : IEntity
    {
        public int ID { get; set; }
        public int SeatID { get; set; }
        public int AgencyID { get; set; }
    }
}
