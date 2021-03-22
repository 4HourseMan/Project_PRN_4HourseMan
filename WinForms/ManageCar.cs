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

        public string CategoryID => cbCategory.SelectedValue.ToString();

        public string SupplierID => cbSupplier.SelectedValue.ToString();

        public float Price => float.Parse(txtPrice.Text);

        public int Quantity => Int32.Parse(txtQuantity.Text);

        public string SearchName => txtSearchName.Text;

        public ManageCar()
        {
            InitializeComponent();
        }

        private void ManageCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddProduct pop = new FormAddProduct();
            pop.Show();
            LoadData();
        }
        private void LoadData()
        {
            MCP = new ManagerCarPresenter(this);
            List<Product> list = MCP.SearchProduct();
            tblCar.DataSource = list;
            List<Category> list1 = MCP.GetCate();
            cbCategory.DataSource = list1;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            List<Supplier> listS = MCP.GetSup();
            cbSupplier.DataSource = listS;
            cbSupplier.DisplayMember = "SupName";
            cbSupplier.ValueMember = "SupID";
        }
        private void ManageCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MCP = new ManagerCarPresenter(this);
            if (MCP.UpdateProduct())
            {
                MessageBox.Show("OK");
                LoadData();
            }
            else
            {
                MessageBox.Show("Not OK");
            }
        }

        private void tblCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCar.Rows[e.RowIndex];
                txtProductID.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                cbCategory.SelectedValue = row.Cells[2].Value.ToString();
                cbSupplier.SelectedValue = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtQuantity.Text = row.Cells[5].Value.ToString();
                txtCreateDate.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MCP = new ManagerCarPresenter(this);
            if (MCP.DeleteProduct())
            {
                MessageBox.Show("OK");
                LoadData();
            }
            else
            {
                MessageBox.Show("Not OK");
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
