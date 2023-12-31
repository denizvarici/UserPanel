﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Panel.Entitites.Concrete;

namespace Panel.Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Username).NotEmpty().WithMessage("Kullanıcı adı bos bırakılamaz!");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz!");
            RuleFor(u => u.Username).Must(StartsWithLetter).WithMessage("Kullanıcı adı bir harf ile başlamalı!");
            RuleFor(u => u.Mail).Must(ContainMailSign).WithMessage("Lütfen girilen mail adresini kontrol ediniz.");
        }

        private bool ContainMailSign(string arg)
        {
            if (arg!=null)
            {
                bool contains = false;
                foreach (char c in arg)
                {
                    if (c == '@')
                    {
                        contains = true;
                    }
                }
                return contains;
            }
            else
            {
                return true;
            }
            

            
        }

        private bool StartsWithLetter(string arg)
        {   
            if(arg.Length >0)
                return (!char.IsDigit(arg[0]));
            else
            {
                return true;
            }
        }
    }
}
