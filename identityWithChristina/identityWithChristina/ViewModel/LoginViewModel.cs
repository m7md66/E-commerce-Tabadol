﻿using System.ComponentModel.DataAnnotations;

namespace identityWithChristina.ViewModel
{
    public class LoginViewModel


    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsPresist { get; set; }
    }
}
