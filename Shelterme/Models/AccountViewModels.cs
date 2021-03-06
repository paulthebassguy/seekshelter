﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Shelterme.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Required]
        [Display(Name = "Shelter name")]
        public string ShelterProviderName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required]
        public string ContactPhone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Beds available")]
        public int MaxBedsAvailable { get; set; }

        [Display(Name = "Women")]
        public bool AllowWomen { get; set; }

        [Display(Name = "Men")]
        public bool AllowMen { get; set; }

        [Display(Name = "Children")]
        public bool AllowChildren { get; set; }

        public string AvailablityDisplayString
        {
            get
            {
                var list = new List<string>();
                if (AllowWomen) list.Add("Women");
                if (AllowMen) list.Add("Men");
                if (AllowChildren) list.Add("Children");

                return string.Join(" and ", list);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class RegisterDetailsViewModel
    {
        [Display(Name = "Your name")]
        public string ShelterProviderName { get; set; }

        public string City { get; set; }
        public string Suburb { get; set; }


        public string Address { get; set; }

        [Display(Name = "Contact phone")]
        public string ContactPhone { get; set; }

        [Display(Name = "Number of beds available")]
        public int MaxBedsAvailable { get; set; }

        [Display(Name = "Women")]
        public bool AllowWomen { get; set; }

        [Display(Name = "Men")]
        public bool AllowMen { get; set; }

        [Display(Name = "Children")]
        public bool AllowChildren { get; set; }

        public string AvailablityDisplayString
        {
            get
            {
                var list = new List<string>();
                if (AllowWomen) list.Add("Women");
                if (AllowMen) list.Add("Men");
                if (AllowChildren) list.Add("Children");

                return string.Join(" and ", list);
            }
        }
    }
    

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
