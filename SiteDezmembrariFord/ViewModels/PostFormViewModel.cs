using SiteDezmembrariFord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteDezmembrariFord.ViewModels
{
    public class PostFormViewModel
    {
        public Post Post { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public IEnumerable<Counties> Counties { get; set; }
    }
}