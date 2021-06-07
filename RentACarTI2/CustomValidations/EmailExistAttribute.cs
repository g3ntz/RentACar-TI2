using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using RentACarTI2.Models;
using RentACarTI2.BLL;

namespace RentACarTI2.CustomValidations
{
    public class EmailExistAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var idProperty = validationContext.ObjectType.GetProperty("UserID");
            int? userID = 0;
            if (idProperty != null)
                userID = (int?)idProperty.GetValue(validationContext.ObjectInstance, null);

            string email = value.ToString();
            var existingUser = UserBLL.userDAL.GetAll().Where(x => x.Email == email).FirstOrDefault();

            if (userID != null)
            {
                if (existingUser == null || existingUser.UserID == userID)
                    return ValidationResult.Success;
                else
                    return new ValidationResult(this.ErrorMessage);
            }
            else
            {
                if (existingUser == null)
                    return ValidationResult.Success;
                else
                    return new ValidationResult(this.ErrorMessage);
            }
        }
    }
}