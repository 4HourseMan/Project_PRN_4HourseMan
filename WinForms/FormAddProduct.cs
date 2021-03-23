using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class FormAddProduct : Form, IManageCarView
    {
        private ManagerCarPresenter MCP;
        public FormAddProduct()
        {
            InitializeComponent();
        }

        public string ProductID => txtProductID.Text;

        public string ProductName1 => txtProductName.Text;

        public string CategoryID => cbCategory.SelectedValue.ToString();

        public string SupplierID => cbSupplier.SelectedValue.ToString();

        public float Price => float.Parse(txtPrice.Text);

        public int Quantity => int.Parse(txtQuantity.Text);

        public string SearchName => null;
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
        private void btnCreate_Click(object sender, EventArgs e)
        {


            string ProductID = txtProductID.Text.Trim();
            string ProductName1 = txtProductName.Text.Trim();
            string Price = txtPrice.Text.Trim();
            string Quantity = txtQuantity.Text.Trim();
            if (ProductID.Equals("") || ProductName1.Equals("") || Price.Equals("") || Quantity.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if (!checkID(ProductID))
                {
                    err += "Wrong ID format\n";
                }
                if (!checkString(ProductName1, 50))
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
                else
                {
                    MessageBox.Show(err);
                }
            }





        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            MCP = new ManagerCarPresenter(this);
            List<Category> list = MCP.GetCate();
            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            List<Supplier> listS = MCP.GetSup();
            cbSupplier.DataSource = listS;
            cbSupplier.DisplayMember = "SupName";
            cbSupplier.ValueMember = "SupID";

        }

    }
}
