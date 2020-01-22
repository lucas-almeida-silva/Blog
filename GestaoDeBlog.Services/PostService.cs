using AutoMapper;
using GestaoDeBlog.Data.Repositories.Interfaces;
using GestaoDeBlog.Models;
using GestaoDeBlog.Services.Exceptions;
using GestaoDeBlog.Services.Interfaces;
using GestaoDeBlog.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GestaoDeBlog.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repository;
        private readonly IMapper mapper;

        public PostService(IPostRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this.mapper = mapper;
        }

        public void InsertPost(PostInsertVm postVm)
        {
            if (CheckDuplicateTitle(postVm))
            {
                throw new BusinessRoleException("Já existe um post com esse título");
            }
            this._repository.Insert(mapper.Map<Post>(postVm));
        }

        public void DeletePost(PostDeleteVm postVm)
        {
            var post = this._repository.GetById(postVm.PostId);
            this._repository.Delete(post);
        }

        public void UpdatePost(PostEditVm postVm)
        {
            this._repository.Update(mapper.Map<Post>(postVm));
        }

        public IEnumerable<PostListVm> ListPosts()
        {
            var list = this._repository.List();
            return mapper.Map<IEnumerable<PostListVm>>(list);
        }

        public Post GetById(int id)
        {
            return this._repository.GetById(id);
        }

        public Post GetByTitle(string title)
        {
            return this._repository.GetByTitle(title);
        }

        public bool CheckDuplicateTitle(PostInsertVm postVm)
        {
            var post = GetByTitle(postVm.Titulo);

            if (post != null)
            {
                return true;
            }
            return false;
        }
    }
}
