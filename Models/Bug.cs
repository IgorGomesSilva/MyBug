using System;
using System.ComponentModel.DataAnnotations;

namespace myBug.Models
{
    public class Bug
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(60)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(20)]
        public string Severidade { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        public DateTime DataRegistro { get; set; }

        [Required]
        [MaxLength(60)]
        public string Produto { get; set; }
    }
}