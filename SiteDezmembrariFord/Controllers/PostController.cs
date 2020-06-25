using SiteDezmembrariFord.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteDezmembrariFord.ViewModels;
using System.Data.Entity;

namespace SiteDezmembrariFord.Controllers
{
    public class PostController : Controller
    {
        private ApplicationDbContext _context;
        public PostController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowPieseRon()
        {
            var viewModel = _context.Posts.Include(p => p.Counties).Where(p => p.PostType == true).ToList();
            foreach (var view in viewModel)
            {
                view.Pret = (float)Math.Round((Double)view.Pret, 2);
            }
            return View("ShowPiese", viewModel);
        }
        public ActionResult ShowPieseEuro()
        {
            var viewModel = _context.Posts.Include(p => p.Counties).Where(p => p.PostType == true).ToList();
            foreach(var view in viewModel)
            {
                view.Pret *= 0.21f;
                view.Pret = (float)Math.Round((Double)view.Pret, 2);
            }
            return View("ShowPiese", viewModel);
        }
        public ActionResult ShowDezmembrari()
        {
            var viewModel = _context.Posts.Include(p => p.Counties).Where(p => p.PostType == false).ToList();
            return View(viewModel);
        }
        [Authorize(Roles = "User,Admin")]
        public ActionResult New()
        {
            var viewModel = new PostFormViewModel
            {
                Post = new Post
                {
                    UserId = User.Identity.GetUserId(),
                    Date = DateTime.Now,
                    Pret = 0,
                    PostType = false
                },
                SubCategories = _context.SubCategories.ToList(),
                Counties = _context.Counties.ToList()
            };
            return View("New", viewModel);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public ActionResult Save(Post post)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new PostFormViewModel
                {
                    Post = post,
                    SubCategories = _context.SubCategories.ToList(),
                    Counties = _context.Counties.ToList()
                };
                return View("New", viewModel);
            }
            if(post.Id == 0)
                _context.Posts.Add(post);
            else
            {
                var postInDb = _context.Posts.Single(p => p.Id == post.Id);
                postInDb.PostType = post.PostType;
                postInDb.Pret = post.Pret;
                postInDb.SubCategoryId = post.SubCategoryId;
                postInDb.Title = post.Title;
                postInDb.Description = post.Description;
                postInDb.Date = post.Date;
                postInDb.CountiesId = post.CountiesId;
                //this is wrong
                if (postInDb.PostType == false)
                {
                    postInDb.Pret = null;
                    postInDb.SubCategoryId = null;
                    postInDb.SubCategory = null;
                }
            }
           
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "User,Admin")]
        public ActionResult Edit(int id)
        {
            var viewModel = new PostFormViewModel
            {
                Post = _context.Posts.Include(p => p.SubCategory).Include(p => p.User).SingleOrDefault(p => p.Id == id),
                SubCategories = _context.SubCategories.ToList(),
                Counties = _context.Counties.ToList()
            };
            if (viewModel.Post == null || User.Identity.GetUserId() != viewModel.Post.UserId)
                return HttpNotFound();
            return View("New", viewModel);

        }

        public ActionResult Show(int id)
        {
            var post = _context.Posts.Include(p => p.SubCategory).Include(p => p.User).Include(p => p.Counties).SingleOrDefault(c => c.Id == id);
            if (post.SubCategory == null)
            {
                post.SubCategory = new SubCategory
                {
                    Name = ""
                };
            }
            if (post == null)
                return HttpNotFound();
            var viewModel = new ShowPostViewModel
            {
                Post = post,
                IsAdmin = false,
                IsOwner = false
            };
            var userId = User.Identity.GetUserId();

            if (userId == post.UserId)
                viewModel.IsOwner = true;

            if (User.IsInRole("Admin"))
                viewModel.IsAdmin = true;

            return View("Show", viewModel);
        }

    }
}