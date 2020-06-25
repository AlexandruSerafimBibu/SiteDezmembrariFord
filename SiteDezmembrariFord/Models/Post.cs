using SiteDezmembrariFord.Models.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteDezmembrariFord.Models
{
    public class Post
    {
        public int Id { get; set; }
        public ApplicationUser User { set; get; }
        [Required]
        [MaxLength(128)]
        public string UserId { get; set; }
        [Display(Name = "Titlu")]
        [Required(ErrorMessage = "Titlul este obligatoriu")]
        [MaxLength(50)]
        public string Title { get; set; }
        [Display(Name = "Decriere")]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Display(Name="Judet")]
        [Required(ErrorMessage = "Judetul este obligatoriu")]
        public int CountiesId { get; set; }
        public Counties Counties { get; set; }
        [Required]
        [Display(Name ="Tipul anuntului")]
        public bool PostType { get; set; }
        [MandatoryPriceForPiese]
        public float? Pret { get; set; }
        public SubCategory SubCategory { get; set; }
        [Display(Name = "Categorie")]
        [MandatorySubCategoryIdForPiese]
        public int? SubCategoryId { get; set; }

    }
}