using BusinessObjects;
using System;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class FormAddProduct : Form,IManageCarView
    {
        private ManagerCarPresenter MCP;
        public FormAddProduct()
        {
            InitializeComponent();
        }

        public string ProductID => txtProductID.Text;

        public string ProductName1 => txtProductName.Text;

        public string CategoryID => cbCategory.Text;

        public string SupplierID => cbSupplier.Text;

        public float Price => float.Parse( txtPrice.Text);

        public int Quantity => int.Parse(txtQuantity.Text);

        public string SearchName => null;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MCP = new ManagerCarPresenter(this);
            if (MCP.AddProduct())
            {
                MessageBox.Show("OK");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not OK");
            }
        }
    }
}
