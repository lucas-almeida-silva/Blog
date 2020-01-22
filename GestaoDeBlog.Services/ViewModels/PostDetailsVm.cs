using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestaoDeBlog.Services.ViewModels
{
    public class PostDetailsVm
    {
        [Display(Name = "ID")]
        public int PostId { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }

        public string Autor { get; set; }

        [Display(Name = "Criação")]
        public DateTime Criacao { get; set; }

        public string Url { get; set; }

        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }

        public bool Ativo { get; set; }
    }
}


