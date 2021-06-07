using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RentACarTI2.CustomHelpers;

namespace RentACarTI2.CustomValidations
{
    public class UsernameOrEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string valueString = value.ToString();
            if(UsernameOrEmail.usernameOrEmail(valueString) != null)
            {
                if (valueString.Length < 3 || valueString.Length > 50)
                    return new ValidationResult(ErrorMessage = "Email should be between 3-50 characters");
                else
                    return ValidationResult.Success;
            }
            else
            {
                if (valueString.Length < 2 || valueString.Length > 15)
                    return new ValidationResult(ErrorMessage = "Username should be between 2-15 characters");
                else
                    return ValidationResult.Success;
            }
        }
    }
}
