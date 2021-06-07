using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.Models;
using System.ComponentModel.DataAnnotations;
using RentACarTI2.CustomValidations;

namespace RentACarTI2.ViewModels
{
    public class RegisterViewModel
    {
        // USER
        public int? UserID { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MinLength(2, ErrorMessage = "Username cannot be shorter than 2 characters")]
        [MaxLength(15, ErrorMessage = "Username cannot be longer than 15 characters")]
        [UsernameExist(ErrorMessage = "This username already exists")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MinLength(3, ErrorMessage = "Email cannot be shorter than 3 characters")]
        [MaxLength(50, ErrorMessage = "Email cannot be longer than 50 characters")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid Email")]
        [EmailExist(ErrorMessage = "This email already exists")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password cannot be shorter than 6 characters")]
        [MaxLength(100, ErrorMessage = "Password cannot be longer than 100 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [MinLength(6, ErrorMessage = "Confirm Password cannot be shorter than 6 characters")]
        [MaxLength(100, ErrorMessage = "Confirm Password cannot be longer than 100 characters")]
        [Compare("Password",ErrorMessage = "Confirmed Password do not match")]
        public string ConfirmPassword { get; set; }

        // CLIENT
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name cannot be shorter than 2 characters")]
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [MinLength(2, ErrorMessage = "Surname cannot be shorter than 2 characters")]
        [MaxLength(30, ErrorMessage = "Surname cannot be longer than 30 characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Birthdate is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:MM}")]
        [DataType(DataType.Date)]
        [InvalidDate(ErrorMessage = "You're not old enough to register")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MinLength(5, ErrorMessage = "Address cannot be shorter than 5 characters")]
        [MaxLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Nr is required")]
        [MinLength(8, ErrorMessage = "Phone Nr should contain at least 8 numbers")]
        [MaxLength(11, ErrorMessage = "Phone Nr cannot contain more than 11 numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Invalid Phone Nr, only numbers allowed")]
        public string PhoneNr { get; set; }

        [Required(ErrorMessage = "Driving License is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Driving License should contain 10 numbers")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Driving License should contain only numbers")]
        public string DrivingLicense { get; set; }

        public DateTime LastLoginDate { get; set; }
    }
}
