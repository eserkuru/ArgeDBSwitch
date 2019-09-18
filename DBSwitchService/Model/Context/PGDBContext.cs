using DBSwitchService.Model.Entity;
using DBSwitchService.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSwitchService.Model.Context
{
    public class PGDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            JsonReader jsonReader = new JsonReader();
            optionsBuilder.UseNpgsql(jsonReader.ConnectionStrings("ArgeDB2"));
        }
    }
}
