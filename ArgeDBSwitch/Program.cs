using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using DBSwitchService;
using DBSwitchService.Model.Context;
using DBSwitchService.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ArgeDBSwitch
{
    public class Program
    {

        public static void Main(string[] args)
        {

            var db = new RContext();
            //db.ArgeDB4.Database.EnsureCreated();
            //db.ArgeDB4.Invoices.Add(new Invoice { InvoiceNumber = "0015", Total = "18.00 TL" });
            

            Console.WriteLine("All record in MS SQL database:");
            foreach (var blog in db.ArgeDB.Blogs)
            {
                Console.WriteLine(" - {0}", blog.Url);
            }
            Console.WriteLine("\n______");

            Console.WriteLine("All record in PostgreSQL database:");
            foreach (var student in db.ArgeDB2.Students)
            {
                Console.WriteLine(" - {0}", student.FirstName + " " + student.LastName);
            }
            Console.WriteLine("\n______");

            //Console.WriteLine("All record in MySQL database:");
            //foreach (var invoice in db.ArgeDB4.Invoices)
            //{
            //    Console.WriteLine(" - {0}", invoice.InvoiceNumber + " = " + invoice.Total);
            //}
            //Console.WriteLine("\n______");






            Console.WriteLine("All record in MongoDB database:");
            var collection = db.ArgeDB3.Orders;
            var cursorFind = collection.Find(new BsonDocument()).ToCursor();
            foreach (var document in cursorFind.ToEnumerable())
            {
                Console.WriteLine(document);
            }
            Console.WriteLine("\n______");

            //var query = db.ArgeDB2.Students.Where(x => x.FirstName=="Gözde");
            //Console.WriteLine(query);
        }
    }
}
