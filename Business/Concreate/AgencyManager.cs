using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class AgencyManager : IAgencyService
    {
        IAgencyDal _agencyDal;

        public AgencyManager(IAgencyDal agencyDal)
        {
            _agencyDal = agencyDal;
        }
        //kfglk
    }
}
