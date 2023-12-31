﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panel.Business.Abstract;
using Panel.Business.Concrete;
using Panel.DataAccess.Concrete.EntityFramework;
using Panel.Entitites.Concrete;

namespace Panel.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private IUserService _userService;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxPasswordVerification.Text)
            {
                try
                {
                    _userService.ControlUsername(new User
                    {
                        Username = tbxUsername.Text,
                        Password = tbxPassword.Text,
                        Mail = tbxMailAddress.Text
                    });
                    _userService.ControlMail(new User
                    {
                        Username = tbxUsername.Text,
                        Password = tbxPassword.Text,
                        Mail = tbxMailAddress.Text
                    });
                    MailVerificationForm mailVerificationForm = new MailVerificationForm(tbxUsername.Text,tbxPassword.Text,tbxMailAddress.Text);
                    mailVerificationForm.Show();
                    this.Hide();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Parolalar uyumsuz! Tekrar kontrol ediniz");
            }
            
        }

        private void btnSeePswd1_Click(object sender, EventArgs e)
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

        private void btnSeePswd2_Click(object sender, EventArgs e)
        {
            if (tbxPasswordVerification.PasswordChar == '*')
            {
                tbxPasswordVerification.PasswordChar = '\0';
            }
            else
            {
                tbxPasswordVerification.PasswordChar = '*';
            }
        }

        private void gbxLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
