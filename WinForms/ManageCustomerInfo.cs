using BusinessObjects;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class ManageCustomerInfo : Form, IManageCustomerView
    {
        private ManageCustomerPresenter MCP;
        public ManageCustomerInfo()
        {
            InitializeComponent();
            this.CenterToScreen();
            MCP = new ManageCustomerPresenter(this);
            txtPhone.ReadOnly = true;
        }

        public string Phone => txtPhone.Text.Trim();

        public string CusName => txtName.Text.Trim();

        public string Email => txtEmail.Text.Trim();

        public string Address => txtAddress.Text.Trim();

        public string SearchPhone => txtSearchPhone.Text.Trim();

        private void LoadData()
        {
            List<CustomerInfo> list = MCP.GetAllCustomer();
            tblCustomer.DataSource = list;

            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtSearchPhone.Text = "";
            txtAddress.Text = "";
        }

        private void ManageCustomerInfo_Load(object sender, System.EventArgs e)
        {
            LoadData();
        } 

        private void btnGetAll_Click(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (CusName.Equals("") || Email.Equals("") || Address.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                if (MCP.UpdateCustomer())
                {
                    LoadData();
                    MessageBox.Show("Update Successful!");
                }
                else
                {
                    MessageBox.Show("Update Fail!");
                }
            }
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            FormAddCustomer customer = new FormAddCustomer();
            customer.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (MCP.DeleteCustomer())
            {
                LoadData();
                MessageBox.Show("Delete Successful!");
            }
            else
            {
                MessageBox.Show("Delete Fail!");
            }
        }

        private void btnSearchByPhone_Click(object sender, System.EventArgs e)
        {
            List<CustomerInfo> list = MCP.SearchCustomer();
            if (list != null)
            {
                tblCustomer.DataSource = list;

                txtName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtAddress.Text = "";
            }
            else
            {
                MessageBox.Show("This Phone doesnt exist!");
            }
        }

        private void tblCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCustomer.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[0].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
            }
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }


    }
}
