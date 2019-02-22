﻿using MyBase.BLL.DTO;
using MyBase.BLL.Interfaces;
using MyBase.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBase.BLL.Mappers
{
    public class UserMapper : IMapper<UserDTO, User>
    {
        public User Convert(UserDTO source)
        {
            return new User
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                ContactId = source.ContactId,
                //Contact = source.Contact
            };
        }

        public UserDTO Convert(User source)
        {
            return new UserDTO
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                ContactId = source.ContactId,
                PhoneNumber = source.Contact.PhoneNumber,
                Email = source.Contact.Email
                //Contact = source.Contact
            };
        }
    }
}

