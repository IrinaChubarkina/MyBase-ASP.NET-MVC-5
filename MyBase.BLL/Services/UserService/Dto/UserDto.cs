﻿using System.IO;

namespace MyBase.BLL.Services.UserService.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public Stream Stream { get; set; }
        public string FileName { get; set; }
    }
}
