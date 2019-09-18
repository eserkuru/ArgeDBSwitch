using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSwitchService.Model.Entity
{
    public class Customer
    {
        public ObjectId Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
    }
}
