using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panel.Business.MailVerification;

using MailKit.Security;
using MimeKit;
using MailKit.Net.Smtp;
using Panel.Business.Abstract;
using Panel.Business.Concrete;
using Panel.DataAccess.Concrete.EntityFramework;
using Panel.Entitites.Concrete;

namespace Panel.UI
{
    public partial class MailVerificationForm : Form
    {
        public MailVerificationForm(string userName,string userPassword,string userMailAdress)
        {
            InitializeComponent();
            _mailSender = new MailSender();

            _userName = userName;
            _userPassword = userPassword;
            _userMailAdress = userMailAdress;
            
            _userService = new UserManager(new EfUserDal());
        }

        private int _verificationCode;
        private string _verificationCodeString;
        private string _userVerificationTry;

        private MailSender _mailSender;
        private string _userMailAdress;
        private string _userPassword;
        private string _userName;
        private IUserService _userService;
        public int GenerateRandomNumber(int digit)
        {
            Random random = new Random();
            string stringNumber = null;
            List<string> numberList = new List<string>
            {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            };
            for (int i = 0; i < digit; i++)
            {

                stringNumber += random.Next(0, 10).ToString();
            }

            return Convert.ToInt32(stringNumber);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _verificationCodeString = _verificationCode.ToString();
            _verificationCodeString.Insert(_verificationCodeString.Length / 2, "-");

            _userVerificationTry = mskTbxMailVerification.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            

            if (_verificationCodeString == _userVerificationTry)
            {
                try
                {
                    _userService.SignUp(new User
                    {
                        Username = _userName,
                        Password = _userPassword,
                        Mail = _userMailAdress
                    });
                    MessageBox.Show("Kayıt başarılı! Lütfen sisteme giriş yapınız!");
                    this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Doğrulama kodunu yanlış girdiniz. Lütfen tekrar deneyiniz!");
            }


        }

        private void MailVerificationForm_Load(object sender, EventArgs e)
        {
            


        }

        private void btnSendMeVerificationMail_Click(object sender, EventArgs e)
        {
            _verificationCode = GenerateRandomNumber(6);
            try
            {
                _mailSender.SendSignUpCodeMail(_verificationCode,_userMailAdress);
                btnSendMeVerificationMail.Hide();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Şuanda sistemlerimizde bir hata var! Lütfen daha sonra tekrar deneyiniz!");
                Console.WriteLine(exception.Message);
            }
            
               
        }
    }
    }


    
