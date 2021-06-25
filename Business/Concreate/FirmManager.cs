using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class FirmManager : IFirmService
    {
        IFirmDal _firmDal;

        public FirmManager(IFirmDal firmDal)
        {
            _firmDal = firmDal;
        }
    }
}
