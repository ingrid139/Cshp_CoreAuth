﻿using System.ComponentModel.DataAnnotations;


namespace CoreAuth.DTO
{
    public class ForgotPasswordDTO
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }
    }
}
