using SiteDezmembrariFord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SiteDezmembrariFord.ViewModels;
namespace SiteDezmembrariFord.Controllers
{
    public class SubCategoryController : Controller
    {
        private ApplicationDbContext _context;
        public SubCategoryController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var subCategories = _context.SubCategories.Include(c => c.Category).ToList();

            return View(subCategories);
        }
        public ActionResult New()
        {
            var viewModel = new SubCategoryFormViewModel
            { 
                Categories = _context.Categories.ToList()
            };
            return View("SubCategoryForm", viewModel);
        }
        public ActionResult Edit(int id)
        {
            var viewModel = new SubCategoryFormViewModel
            {
                SubCategory = _context.SubCategories.Include(c => c.Category).Single(c => c.Id == id),
                Categories = _context.Categories.ToList()
            };
            return View("SubCategoryForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(SubCategory subCategory)
        {
            if(!ModelState.IsValid)
            //if(subCategory.Name == null || subCategory.CategoryId == 0)
                {
               // var errors = ModelState.Values.SelectMany(v => v.Errors);
                var viewModel = new SubCategoryFormViewModel
                {
                    SubCategory = subCategory,
                    Categories  = _context.Categories.ToList()
                };
                return View("SubCategoryForm", viewModel);
            }
          
            if(subCategory.Id == 0)
            {
                _context.SubCategories.Add(subCategory);
            }
            else
            {
                var dbSubCategory = _context.SubCategories.Single( s => s.Id == subCategory.Id);
                dbSubCategory.Name = subCategory.Name;
                dbSubCategory.CategoryId = subCategory.CategoryId;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "SubCategory");
        }
    }
}