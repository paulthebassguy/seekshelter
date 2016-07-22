using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shelterme.Data.Models
{
    public class ShelterProvider
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }

        public string ShelterProviderName { get; set; }

        public string Location { get; set; }

        public string ContactDetails { get; set; }

        public int BedsAvailable { get; set; }


        public bool AllowWomen { get; set; }
        public bool AllowMen { get; set; }
        public bool AllowChildren { get; set; }

    }
}