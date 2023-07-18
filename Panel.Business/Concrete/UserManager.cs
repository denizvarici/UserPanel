using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panel.Business.Abstract;
using Panel.Business.Utilities;
using Panel.Business.ValidationRules.FluentValidation;
using Panel.DataAccess.Abstract;
using Panel.DataAccess.Concrete;
using Panel.DataAccess.Concrete.EntityFramework;
using Panel.Entitites.Concrete;

namespace Panel.Business.Concrete
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public bool Login(User user)
        {
            ValidationTool.Validate(new UserValidator(),user);
            return _userDal.Login(user);
        }

        public void SignUp(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.SignUp(user);
        }

        public void ControlUsername(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.ControlUsername(user);
        }

        public void ControlMail(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.ControlMailAddress(user);
        }
    }
}
