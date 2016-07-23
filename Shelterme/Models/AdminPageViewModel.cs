using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shelterme.Models
{
    public class AdminPageViewModel
    {
        [Display(Name = "Number of beds available")]
        public int CurrentBedsAvailable { get; set; }

        [Display(Name = "Men")]
        public bool AllowMen { get; set; }

        [Display(Name = "Women")]
        public bool AllowWomen { get; set; }

        [Display(Name = "Children")]
        public bool AllowChildren { get; set; }


    }
}