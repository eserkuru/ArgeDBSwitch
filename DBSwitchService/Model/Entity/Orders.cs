using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSwitchService.Model.Entity
{
    public class Orders
    {
        public ObjectId Id { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }

    }
}
