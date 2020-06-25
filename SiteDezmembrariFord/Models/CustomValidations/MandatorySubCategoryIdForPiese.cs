using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteDezmembrariFord.Models.CustomValidations
{
    public class MandatorySubCategoryIdForPiese: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var post = (Post)validationContext.ObjectInstance;
        if (post.PostType == true && post.SubCategoryId == null)
            return new ValidationResult("Categoria este obligatorie");
        
        return ValidationResult.Success;
    }
}
}