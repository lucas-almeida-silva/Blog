using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestaoDeBlog.Services.ViewModels
{
    public class PostInsertVm
    {

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(50)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(30)]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(80)]
        public string Url { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool Ativo { get; set; }
    }
}