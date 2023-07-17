using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel.Entitites.Concrete;

namespace Panel.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        bool Login(User user);

        void SignUp(User user);
    }
}
