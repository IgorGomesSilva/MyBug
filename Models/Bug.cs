using System;
using System.ComponentModel.DataAnnotations;

namespace myBug.Models
{
    public class Bug
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Severidade { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime DataRegistro { get; set; }

        [Required]
        public string Produto { get; set; }
    }
}