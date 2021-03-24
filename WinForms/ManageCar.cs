using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;
using System.Text.RegularExpressions;

namespace WinForms
{
    public partial class ManageCar : Form, IManageCarView
    {
        private ManagerCarPresenter MCP;
        public string ProductID => txtProductID.Text.Trim();

        public string ProductName1 => txtProductName.Text.Trim();

        public string CategoryID => cbCategory.SelectedValue.ToString();

        public string SupplierID => cbSupplier.SelectedValue.ToString();

        public float Price => float.Parse(txtPrice.Text.Trim());

        public int Quantity => Int32.Parse(txtQuantity.Text.Trim());

        public string SearchName => txtSearchName.Text.Trim();

        public ManageCar()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ManageCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddProduct pop = new FormAddProduct();
            pop.ShowDialog();
            LoadData();
        }

        private bool checkInt(string num)
        {
            bool check = true;
            try
            {
                int alo = int.Parse(num);
                if (alo <= 0)
                {
                    check = false;
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        private bool checkFloat(string num)
        {
            bool check = true;
            try
            {
                float alo = float.Parse(num);
                if (alo <= 0)
                {
                    check = false;
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        private bool checkString(string stri, int num)
        {
            bool check = true;
            if (stri.Trim().Length > num)
            {
                check = false;
            }
            return check;
        }

        private bool checkID(string stri)
        {
            bool check = true;
            if (!Regex.IsMatch(stri, "(?i)^(?=.*[a-z])[a-z0-9]{1,10}$"))
            {
                check = false;
            }
            return check;
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
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtSearchName.Text = "";
            txtCreateDate.Text = "";
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
            string ProductName1 = txtProductName.Text.Trim();
            string Price = txtPrice.Text.Trim();
            string Quantity = txtQuantity.Text.Trim();
            if ( ProductName1.Equals("") || Price.Equals("") || Quantity.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if (!checkString(ProductName1 , 50))
                {
                    err += "Name length <= 50\n";
                }
                if (!checkInt(Quantity))
                {
                    err += "Quantity is int number\n";
                }
                if (!checkFloat(Price))
                {
                    err += "Price is number\n";
                }
                if (err.Equals(""))
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
                else
                {
                    MessageBox.Show(err);
                }
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
    }
}
