using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Cliente
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Informe um nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe sua data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe seu CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Informe seu email")]
        public string Email { get; set; }
    }
}