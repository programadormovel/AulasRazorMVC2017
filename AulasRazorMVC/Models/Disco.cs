using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulasRazorMVC.Models
{
    public class Disco
    {
        [DisplayName("Nome do Disco: ")]
        [StringLength(50, ErrorMessage = "O campo nome permite no máximo 50 caracteres.")]
        public string disco { get; set; }
        [DisplayName("Nome do Artista: ")]
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string artista { get; set; }
        [DisplayName("Nome do faixas: ")]
        public string faixas { get; set; }

    }
}