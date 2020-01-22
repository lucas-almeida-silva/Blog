using GestaoDeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GestaoDeBlog.Data.Repositories.Interfaces  
{ 
    public interface IPostRepository
    {
        void Insert(Post post);
        void Update(Post post);
        void Delete(Post post);
        IEnumerable<Post> List();
        Post GetById(int id);
        Post GetByTitle(string title);
    }
}
