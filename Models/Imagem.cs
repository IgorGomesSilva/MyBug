using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace myBug.Models
{
    public class Imagem
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImgCaminho { get; set; }

        [Required]
        public string ImagName { get; set; }


    }
}
