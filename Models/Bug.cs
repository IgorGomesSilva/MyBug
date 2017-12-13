using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;

namespace myBug.Models
{
    public class Bug
    {

        public Bug()
        {
            DataRegistro = DateTime.Now;
            Status = false;
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

        [Required]
        public bool Status { get; set; }

        public IEnumerable<Comentario> BugsComentario { get; set; }

        public DateTime DataRegistro { get; set; }

    }
}