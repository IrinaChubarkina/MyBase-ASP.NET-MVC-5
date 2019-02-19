﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBase.WEB.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ContactId { get; set; }
    }
}