using DBSwitchService.Model.Entity;
using DBSwitchService.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSwitchService.Model.Context
{
    public class MSDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            JsonReader jsonReader = new JsonReader();
            optionsBuilder.UseSqlServer(jsonReader.ConnectionStrings("ArgeDB"));
        }
    }
}
