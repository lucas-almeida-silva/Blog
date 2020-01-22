using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GestaoDeBlog.Models;
using GestaoDeBlog.Services.ViewModels;

namespace GestaoDeBlog.Services.Mappers
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<PostInsertVm, Post>().ReverseMap();
            CreateMap<PostEditVm, Post>().ReverseMap();
            CreateMap<Post, PostListVm>().ReverseMap();
            CreateMap<PostDetailsVm, Post>().ReverseMap();
            CreateMap<PostDeleteVm, Post>().ReverseMap();
        }
    }
}
