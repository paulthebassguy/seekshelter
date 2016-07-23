using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shelterme.Models
{
    public class SearchAndUpdateViewModel
    {
        public string City { get; set; }

        public string Suburb { get; set; }

        [Display(Name = "Men")]
        public bool SearchMen { get; set; }

        [Display(Name = "Women")]
        public bool SearchWomen { get; set; }

        [Display(Name = "Children")]
        public bool SearchChildren { get; set; }




        [Display(Name = "Number of beds available")]
        public int CurrentBedsAvailable { get; set; }

        [Display(Name = "Men")]
        public bool AllowMen { get; set; }

        [Display(Name = "Women")]
        public bool AllowWomen { get; set; }

        [Display(Name = "Children")]
        public bool AllowChildren { get; set; }

        public bool ShowUpdateConfirmation { get; set; }

    }
}