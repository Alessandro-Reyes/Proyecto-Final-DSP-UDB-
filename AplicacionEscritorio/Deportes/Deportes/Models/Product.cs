using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deportes.Models
{
    public class Product
    {
        public List<Product> Productos { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
    }
}