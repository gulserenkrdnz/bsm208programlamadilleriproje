using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        void Add(User user);
        void Delete(User user);
        void Update(User user);
        User GetById(int id);
        User GetByemail(string email);
        User LoginCheck(string email, string password);

    }
}
