using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryID { get; set; }
        public string SupplierID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string CreateDate { get; set; }
        public bool Status { get; set; }

    }
}
