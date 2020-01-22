using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoDeBlog.Services.Interfaces;
using GestaoDeBlog.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using GestaoDeBlog.Services;
using GestaoDeBlog.Models;
using System.Diagnostics;
using GestaoDeBlog.Services.Exceptions;
using AutoMapper;

namespace GestaoDeBlog.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostService _postService;
        private readonly IMapper mapper;
        public PostsController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            this.mapper = mapper;
        }


        public IActionResult Index()
        {
            var list = _postService.ListPosts();
            return View(list);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(PostInsertVm postVm)
        {

            if (!ModelState.IsValid)
                return View();

            try
            {
                _postService.InsertPost(postVm);
                return RedirectToAction("Index");
            }
            catch(BusinessRoleException ex)
            {
                ModelState.AddModelError("",ex.Message);
                return View();
            }
            catch(Exception ex)
            {
                ViewData["Erro"] = ex.Message;
                return View("_Erro");
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            try
            {
                var post = _postService.GetById(id);
                if(post == null)
                {
                    throw new Exception("Post não encontrado");
                }
                return View(mapper.Map<PostDetailsVm>(post));
            }
            catch (Exception ex)
            {
                ViewData["Erro"] = ex.Message;
                return View("_Erro");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                var post = _postService.GetById(id);
                if (post == null)
                {
                    throw new Exception("Post não encontrado");
                }
                return View(mapper.Map<PostEditVm>(post));
            }
            catch (Exception ex)
            {
                ViewData["Erro"] = ex.Message;
                return View("_Erro");
            }
        }

        [HttpPost]
        public IActionResult Edit(PostEditVm postVm)
        {

            if (!ModelState.IsValid)
                return View();

            try
            {
                _postService.UpdatePost(postVm);
                return RedirectToAction("Index");
            }
            catch (BusinessRoleException ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ViewData["Erro"] = ex.Message;
                return View("_Erro");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var post = _postService.GetById(id);
                if (post == null)
                {
                    throw new Exception("Post não encontrado");
                }
                return View(mapper.Map<PostDeleteVm>(post));
            }
            catch (Exception ex)
            {
                ViewData["Erro"] = ex.Message;
                return View("_Erro");
            }
        }

        [HttpPost]
        public IActionResult Delete(PostDeleteVm postVm)
        { 
            try
            {
                _postService.DeletePost(postVm);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["Erro"] = ex.Message;
                return View("_Erro");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}