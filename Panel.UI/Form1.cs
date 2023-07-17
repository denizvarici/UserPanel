using Panel.Business.Concrete;
using Panel.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panel.Business.Abstract;
using Panel.DataAccess.Concrete.EntityFramework;
using Panel.Entitites.Concrete;

namespace Panel.UI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private IUserService _userService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgwUser.DataSource = _userService.GetAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool trylogin = _userService.Login(new User
                {
                    Username = tbxUsername.Text,
                    Password = tbxPassword.Text
                });
                if (trylogin)
                {
                    MessageBox.Show("Giris basarili!");
                    tbxUsername.Text = "";
                    tbxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya sifre hatali!");
                }
            }
            catch (Exception exception)
            {
                //string newMessage = exception.Message.Substring(18);
                //MessageBox.Show(newMessage);
                MessageBox.Show(exception.Message);
            }
            
        }

        private void btnSignUpForm_Click(object sender, EventArgs e)
        {
            SignUpForm form2 = new SignUpForm();
            form2.Show();
            
        }

        private void btnRefreshDb_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwUser.CurrentRow != null)
            {
                _userService.Delete(new User
                {
                    Id = Convert.ToInt32(dgwUser.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Seçilen kullanıcı bilgisi veritabanından kaldırıldı!");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Lütfen aşağıdan silmek istediğiniz kullanıcının en sol tarafındaki kutuyu seçiniz.");
            }
                
        }

        private void btnPswdSee_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '*')
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '*';
            }
        }
    }
}
