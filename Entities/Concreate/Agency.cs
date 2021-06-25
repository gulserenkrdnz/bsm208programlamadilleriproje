using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Agency : IEntity
    {
        public int ID { get; set; }
        public string AgencyName { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
    }
}
