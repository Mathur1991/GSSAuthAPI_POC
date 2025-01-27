﻿using System.ComponentModel.DataAnnotations;

namespace GSSAuthAPI_POC.UserModel
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;
    }
}
