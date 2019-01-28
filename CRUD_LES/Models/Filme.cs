using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_LES.Models
{
    public class Filme
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo genero é obrigatório.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo data é obrigatório.")]
        public string Data { get; set; }

        [Required(ErrorMessage = "O campo estudio é obrigatório.")]
        public string Estudio { get; set; }
    }
}