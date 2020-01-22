using System;

namespace GestaoDeBlog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Criacao { get; set; }
        public string Url { get; set; }
        public string Conteudo { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }

        public Post()
        {
            Excluido = false;
        }

        public Post(string titulo, string autor, DateTime criacao, string url, string conteudo, bool ativo)
        {
            Titulo = titulo;
            Autor = autor;
            Criacao = criacao;
            Url = url;
            Conteudo = conteudo;
            Ativo = ativo;
            Excluido = false;
        }
    }
}
