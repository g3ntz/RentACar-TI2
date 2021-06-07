using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarTI2.CustomValidations
{
    public class InvalidDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;
            if (DateTime.Today.Year - date.Year < 18)
                return new ValidationResult(this.ErrorMessage);
            else
                return ValidationResult.Success;
        }
    }
}
