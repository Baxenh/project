﻿using Microsoft.Identity.Client;
using System;

namespace Lession06_Lab_Entity.Models
{
    public class Account
    {
        public string AccountId {get; set;}
    public string Username { get; set; }
        public string Password { get; set; }
        public string  FullName { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public bool Active { get; set; }

    }
}
