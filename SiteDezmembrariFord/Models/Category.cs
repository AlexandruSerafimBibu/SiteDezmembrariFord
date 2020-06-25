using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteDezmembrariFord.Models
{
    [Bind(Exclude = "Id")]
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele este obligatoriu")]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}