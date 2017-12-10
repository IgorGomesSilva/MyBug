using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace myBug.Models
{
    public class Bug
    {

        public Bug()
        {
            DataRegistro = DateTime.Now;
        }

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

        public string Comentario { get; set; }
    }
}