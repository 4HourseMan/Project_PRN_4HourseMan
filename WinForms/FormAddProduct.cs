using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Presenters;
using BusinessObjects;
namespace WinForms
{
    public partial class FormAddProduct : Form
    {
        private ManagerCarPresenter MCP;
        public FormAddProduct()
        {
            InitializeComponent();
        }

       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            String ProductID = txtProductID.Text;
            String ProductName = txtProductName.Text;
            String CategoryID = cbCategory.Text;
            String Price = txtPrice.Text;
            String Quantity = txtQuantity.Text;
            String SupplierID = cbSupplier.Text;
            String Status = txtProductID.Text;



            DateTime CreateDate = DateTime.Now;
            Product p = new Product(ProductID, ProductName, CategoryID, SupplierID,float.Parse( Price) , int.Parse( Quantity), CreateDate, true);
            MCP.addProduct(p);
        }
    }
}
