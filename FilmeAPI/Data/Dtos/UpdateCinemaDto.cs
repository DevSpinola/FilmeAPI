﻿using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos
{
    public class UpdateCinemaDto
    {        
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
