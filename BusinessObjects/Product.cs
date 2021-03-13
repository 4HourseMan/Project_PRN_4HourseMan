using System;

namespace BusinessObjects
{
    public class Product
    {
        public Product(string productID, string productName, string categoryID, string supplierID, float price, int quantity, DateTime createDate, bool status)
        {
            ProductID = productID;
            ProductName = productName;
            CategoryID = categoryID;
            SupplierID = supplierID;
            Price = price;
            Quantity = quantity;
            CreateDate = createDate;
            Status = status;
        }

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryID { get; set; }
        public string SupplierID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}