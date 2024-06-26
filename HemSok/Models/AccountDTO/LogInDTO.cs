﻿using System.ComponentModel.DataAnnotations;

/*
Author: Marcus Karlsson, Emil Waara
*/
namespace HemSok.Models.AccountDTO
{
    public class LogInDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
