using Shelterme.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shelterme.Data
{
    public class SheltermeContext : DbContext
    {
        public SheltermeContext() : base("SheltermeContext")
        {
        }

        
        public DbSet<ShelterProvider> ShelterProviders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}