using DBSwitchService.Model.Entity;
using DBSwitchService.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSwitchService.Model.Context
{
    public class MyDBContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            JsonReader jsonReader = new JsonReader();
            optionsBuilder.UseMySQL(jsonReader.ConnectionStrings("ArgeDB4"));
        }
    }
}
