using GestaoDeBlog.Models;
using GestaoDeBlog.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GestaoDeBlog.Services.Interfaces
{
    public interface IPostService
    {
        void InsertPost(PostInsertVm postVm);
        void UpdatePost(PostEditVm postVm);
        void DeletePost(PostDeleteVm postVm);
        IEnumerable<PostListVm> ListPosts();
        Post GetById(int id);
        Post GetByTitle(string title);
    }
}