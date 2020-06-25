using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteDezmembrariFord.Models
{
    [Bind(Exclude = "Id")]
    public class SubCategory
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Numele este obligatoriu.")]
        [MaxLength(255)]
        public string Name { get; set; }
        public Category Category { get; set; }
        [Required(ErrorMessage = "Categoria este obligatorie.")]
        public int CategoryId { get; set; }
    }
}