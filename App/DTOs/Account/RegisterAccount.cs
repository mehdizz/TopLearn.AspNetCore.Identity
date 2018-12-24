﻿using System;

namespace App.DTOs.Account
{
    public class RegisterAccount
    {
        public RegisterAccount()
        {
            RegisteredOn = DateTime.Now;
        }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }    

        public DateTime RegisteredOn { get; set; }
    }
}