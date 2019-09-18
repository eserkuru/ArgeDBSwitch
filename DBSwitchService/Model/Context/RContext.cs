using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DBSwitchService.Model.Context
{
    public class RContext
    {
        public MSDBContext ArgeDB { get; set; }
        public PGDBContext ArgeDB2 { get; set; }
        public MongoContext ArgeDB3 { get; set; }
        public MyDBContext ArgeDB4 { get; set; }

        public RContext()
        {
            ArgeDB = new MSDBContext();
            ArgeDB2 = new PGDBContext();
            ArgeDB3 = new MongoContext();
            ArgeDB4 = new MyDBContext();
        }
    }
}
