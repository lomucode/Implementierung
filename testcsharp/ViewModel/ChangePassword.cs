using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testcsharp.ViewModel
{
    public class ChangePassword
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Aktuelles Passwort")]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Neues Passwort")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Passwort bestätigen")]
        [Compare("NewPassword", ErrorMessage =
            "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}