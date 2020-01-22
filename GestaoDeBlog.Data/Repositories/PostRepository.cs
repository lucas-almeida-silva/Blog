using GestaoDeBlog.Data.Repositories.Interfaces;
using GestaoDeBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GestaoDeBlog.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly PostContext _context;

        public PostRepository(PostContext context) 
        {
            this._context = context;
        }

        public void Insert(Post post)
        {
            post.Criacao = DateTime.Now;
            this._context.Add(post);
            this._context.SaveChanges();
        }

        public void Update(Post post)
        {
            this._context.Entry(post).State = EntityState.Modified;
            this._context.Entry(post).Property(p => p.Criacao).IsModified = false;
            this._context.SaveChanges();
        }

        public void Delete(Post post)
        {
            post.Excluido = true;
            Update(post);
        }
   
        public IEnumerable<Post> List()
        {
            return Filter().OrderByDescending(x => x.Criacao).ToList();
        }

        public Post GetById(int id)
        {
            return Filter(x => x.PostId == id).FirstOrDefault();
            //return this._context.Posts.FirstOrDefault(x => x.PostId == id);
        }

        public Post GetByTitle(string title)
        {
            return Filter(x => x.Titulo.Equals(title)).FirstOrDefault();
        }

        private IQueryable<Post> Filter(Expression<Func<Post, bool>> expression = null)
        {
            var query = this._context.Posts.Where(x => !x.Excluido);
            
            return expression == null ? query : query.Where(expression);
        }
    }
}
