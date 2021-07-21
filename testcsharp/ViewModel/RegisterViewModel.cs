using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testcsharp.ViewModel
{
    public class RegisterViewModel
    {
        [Required, MaxLength(70, ErrorMessage = "Name cannot exceed 70 characters")]
        [EmailAddress]
        [Display(Name = "Office  Uni_Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@(uni-siegen|hmu|ipp|uni-mb|unicusano|univ-orleans|vilniustech)\.[a-z]+$",
        ErrorMessage = "Invalid Uni-Mail Format! - Nutzen Sie eine Uni-Mail Adresse der teilnehmenden Universitäten.")]

        [Remote(action: "IsEmailInUse", controller: "Account")]
        //[ValidEmailDomain(AllowedDomain: "student.uni-siegen.de",
        //ErrorMessage = "Email domain must be like student.uni-siegen.de")]

        //[ValidEmailDomain(AllowedDomain = "student"/, zwei =  "student.uni-köln.de"/)]

       


        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]


        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]

        public string ConfirmPassword { get; set; }
    }
}