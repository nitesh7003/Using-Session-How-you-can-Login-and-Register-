﻿using System.ComponentModel.DataAnnotations;

namespace Loginandregister.Models
{
    public class RegisterModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; } // In production, use hashed passwords
    }
}
