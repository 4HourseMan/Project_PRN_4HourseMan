using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class ManageCar : Form, IManageCarView
    {
        private ManagerCarPresenter MCP;
        public string ProductID => txtProductID.Text;

        public string ProductName1 => txtProductName.Text;

        public string CategoryID => cbCategory.Text;

        public string SupplierID => cbSupplier.Text;

        public float Price => float.Parse(txtPrice.Text);

        public int Quantity => int.Parse(txtQuantity.Text);

        public string SearchName => txtSearchName.Text;

        public ManageCar()
        {
            InitializeComponent();
        }

        private void ManageCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddProduct pop = new FormAddProduct();
            pop.Show();
        }
        private void LoadData()
        {
            MCP = new ManagerCarPresenter(this);
            List<Product> list = MCP.SearchProduct();
            tblCar.DataSource = list;
        }
        private void ManageCar_Load(object sender, EventArgs e)
        {
            LoadData() ;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
