using DBSwitchService.Model.Entity;
using DBSwitchService.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSwitchService.Model.Context
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database = null;

        public MongoContext()
        {
            JsonReader jsonReader = new JsonReader();
            var client = new MongoClient(jsonReader.ConnectionStrings("ArgeDB3"));
            if (client != null)
                _database = client.GetDatabase("ArgeDB3");
        }

        public IMongoCollection<BsonDocument> Customers
        {
            get
            {
                return _database.GetCollection<BsonDocument>("Customer");
            }
        }
        public IMongoCollection<BsonDocument> Orders
        {
            get
            {
                return _database.GetCollection<BsonDocument>("Order");
            }
        }
    }
}
