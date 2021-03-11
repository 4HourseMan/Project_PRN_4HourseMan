using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public float TotalPrice { get; set; }
        public string Note { get; set; }
        public string UserID { get; set; }
        public string CusPhone { get; set; }
        public bool Status { get; set; }
    }
}
