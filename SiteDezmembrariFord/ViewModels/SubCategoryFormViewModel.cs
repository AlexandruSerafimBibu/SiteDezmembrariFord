using SiteDezmembrariFord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteDezmembrariFord.ViewModels
{
    public class SubCategoryFormViewModel
    {
        public SubCategory SubCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}