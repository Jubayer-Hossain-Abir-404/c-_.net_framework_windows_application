using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SOFTWARE.Entities
{
    class custom_list
    {
        public class Tax
        {
            public int Id { get; set; }
            public decimal TaxPercentage { get; set; }
            public string Name { get; set; }
        }

        public class Item
        {
            
            public int Id { get; set; }
            public string ItemName { get; set; }
            public string LookupCode { get; set; }
            public string DepartmentI { get; set; }
            public string CategoryI { get; set; }
            public decimal Cost { get; set; }
            public decimal Price { get; set; }
            public decimal Weight { get; set; }
            public string UOM { get; set; }
            public int Quantity { get; set; }
            public int TaxId { get; set; }
            public decimal Tax { get; set; }
            public bool Discount { get; set; }
            public decimal Total { get; set; }
            public bool Action { get; set; }
        }

        public class SalesItem
        {

            public int Id { get; set; }
            public string ItemName { get; set; }
            public string LookupCode { get; set; }
            public string DepartmentI { get; set; }
            public string CategoryI { get; set; }
            public decimal Cost { get; set; }
            public decimal Price { get; set; }
            public decimal Weight { get; set; }
            public string UOM { get; set; }
            public int Quantity { get; set; }
            public int TaxId { get; set; }
            public decimal Tax { get; set; }
            public decimal ItemPrice { get; set; }
            public bool Discount { get; set; }
            public decimal Total { get; set; }
            public bool Action { get; set; }
        }
    }
}
