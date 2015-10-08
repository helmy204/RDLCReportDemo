using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RDLCReportDemo.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext()
            : base("name=InventoryConnectionString")
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}