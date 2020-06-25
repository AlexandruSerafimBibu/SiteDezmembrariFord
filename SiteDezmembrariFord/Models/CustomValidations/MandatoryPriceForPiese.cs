using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteDezmembrariFord.Models.CustomValidations
{
    public class MandatoryPriceForPiese: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var post = (Post)validationContext.ObjectInstance;
            if (post.PostType == true && (post.Pret <= 0 || post.Pret == null))
                return new ValidationResult("Pretul trebuie sa fie numar pozitiv.");

            return ValidationResult.Success;
        }
    }
}