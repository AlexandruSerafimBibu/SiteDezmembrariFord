using SiteDezmembrariFord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteDezmembrariFord.ViewModels
{
    public class ShowPostViewModel
    {
        public Post Post { get; set; }
        public Boolean IsAdmin { get; set; }
        public Boolean IsOwner { get; set; }
    }
}