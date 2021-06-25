using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAgencyService
    {
        Agency LoginCheck(string username, string password);
    }
}
