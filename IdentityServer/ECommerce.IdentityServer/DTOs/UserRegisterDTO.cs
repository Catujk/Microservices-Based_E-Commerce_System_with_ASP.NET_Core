﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce.IdentityServer.DTOs
{
    public class UserRegisterDTO
    {
        public string Username { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }




    }
}
