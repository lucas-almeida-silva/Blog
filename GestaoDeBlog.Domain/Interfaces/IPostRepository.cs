using GestaoDeBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeBlog.Domain.Interfaces
{
    public interface IPostRepository
    {
        void Delete(Post post);
    }
}
