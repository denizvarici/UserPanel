using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel.DataAccess.Abstract;
using Panel.Entitites.Concrete;

namespace Panel.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        void Add(User user);
        void Delete(User user);

        bool Login(User user);
        void SignUp(User user);


    }
}
