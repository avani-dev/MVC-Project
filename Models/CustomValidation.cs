using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class EmployeeViewModel
    {
        [CustomValidation(typeof(EmployeeViewModel), "ValidateDuplicate")]
        [Required(ErrorMessage = "Username is required")]
        [DisplayName("Username")]
        public string Username { get; set; }
        public static ValidationResult ValidateDuplicate(string username)
        {

            bool isValid = true; //Some DB Operation
            if (isValid)
            {
                return ValidationResult.Success;

            }
            else
            {
                return new ValidationResult("Username already exists");
            }

        }
    }
}