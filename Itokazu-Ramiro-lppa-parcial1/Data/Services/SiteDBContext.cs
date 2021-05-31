using Itokazu_Ramiro_lppa_parcial1.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Itokazu_Ramiro_lppa_parcial1.Data.Services
{
    public class SiteDBContext : DbContext
    {
        public DbSet<Afiliados> Afiliados { get; set; }

        public SiteDBContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}