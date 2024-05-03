﻿using System.ComponentModel.DataAnnotations;

namespace HemSok.Models.AccountDTO
{
    public class RegisterDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
  
    }
}