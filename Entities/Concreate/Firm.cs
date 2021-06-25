using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Firm : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
