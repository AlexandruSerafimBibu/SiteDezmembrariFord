using SiteDezmembrariFord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace SiteDezmembrariFord.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;

        public CategoryController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Categorii
        public ActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        public ActionResult New()
        {
            var viewModel = new Category();
            return View("CategoryForm", viewModel);
        }
        public ActionResult Edit(int id)
        {
            var viewModel = _context.Categories.Single(c => c.Id == id);
            if (viewModel == null)
                return HttpNotFound();
            return View("CategoryForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Category category)
        {
            if (!ModelState.IsValid)
                return View("CategoryForm", category);
            if (category.Id == 0)
            {
                 _context.Categories.Add(category);
            }
            else
            {
                var dbCategory = _context.Categories.Single(c => c.Id == category.Id);
                dbCategory.Name = category.Name;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
    }
}