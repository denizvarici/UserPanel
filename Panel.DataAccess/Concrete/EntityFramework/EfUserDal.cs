using System;
using System.Collections.Generic;
using System.Linq;
using Panel.DataAccess.Abstract;
using Panel.Entitites.Concrete;

namespace Panel.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,PanelContext>,IUserDal
    {
        public bool Login(User user)
        {
            using (PanelContext context = new PanelContext())
            {
                User dbUser = context.Users.FirstOrDefault(u => u.Username == user.Username);

                if (dbUser!=null && dbUser.Password == user.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void SignUp(User user)
        {
            using (PanelContext context = new PanelContext())
            {
                if (!context.Users.Any(u => u.Username == user.Username))
                {
                    Add(user);
                }
                else
                {
                    throw new Exception("kullanici adi zaten kullanimda");
                }
            }
        }
    }
}
