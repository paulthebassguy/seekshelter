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

        public string City { get; set; }
        public string Suburb { get; set; }


        public string Address { get; set; }

        public string ContactDetails { get; set; }

        public int MaxBedsAvailable { get; set; }
        public int CurrentBedsAvailable { get; set; }

        public bool AllowWomen { get; set; }
        public bool AllowMen { get; set; }
        public bool AllowChildren { get; set; }

    }
}