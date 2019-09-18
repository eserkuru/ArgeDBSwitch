using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSwitchService.Utility
{
    public class JsonReader
    {
        public IConfiguration Configuration { get; set; }

        public string ConnectionStrings(string database)
        {
            var builder = new ConfigurationBuilder().AddJsonFile(@"C:\Users\eser.kuru\source\repos\ArgeDBSwitch\ArgeDBSwitch\config.json");
            Configuration = builder.Build();
            var connectionString = Configuration[database + ":ConnectionString"];
            return connectionString;
        }
        public string DBServices(string database)
        {
            var builder = new ConfigurationBuilder().AddJsonFile(@"C:\Users\eser.kuru\source\repos\ArgeDBSwitch\ArgeDBSwitch\config.json");
            Configuration = builder.Build();
            var connectionString = Configuration[database + ":DBService"];
            return connectionString;
        }
    }
}
