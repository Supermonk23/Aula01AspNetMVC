﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula01AspNetMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage ="Mínimo de caracteres")]
        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage ="Preencher campo nome")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de caracteres")]
        [DisplayName("Sobrenome do Cliente")]
        [Required(ErrorMessage = "Preencher campo sobrenome")]
        public string SobreNome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DataCadastro { get; set; }


        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de caracteres")]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Preencher campo de e-mail")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        public string Email { get; set; }

    }
}