using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DBSwitchService.Model.Entity
{
    public class Invoice
    {
        [Key]
        public int id { get; set; }
        public string InvoiceNumber { get; set; }
        public string Total { get; set; }
    }
}
