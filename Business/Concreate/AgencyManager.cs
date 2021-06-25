using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
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

        public Agency LoginCheck(string username, string password)
        {
            return _agencyDal.Get(a => a.UserName == username && a.Pass == password);
        }
    }
}
