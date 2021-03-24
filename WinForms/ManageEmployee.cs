using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class ManageEmployee : Form, IUserView
    {
        UserPresenter userPresenter;
        public string UserID => txtUserID.Text.Trim();
        public string UserName => txtUserName.Text.Trim();
        public string Address => txtAddress.Text.Trim();
        public string Phone => txtPhone.Text.Trim();
        public string RoleID => "EMP";
        public string Email => txtEmail.Text.Trim();

        public string SearchName => txtUserNameSearch.Text.Trim();

        public string Password => "";

        public bool Status => true;

        public ManageEmployee()
        {
            InitializeComponent();
            this.CenterToScreen();
            userPresenter = new UserPresenter(this);
        }
        private void LoadEmployee()
        {
            List<User> list = userPresenter.GetAllEmployee();
            if (list.Count == 0)
            {
                MessageBox.Show("This employee'name doesn't exist!");
            }
            else
            {
                txtUserID.ReadOnly = true;
                dgvEmployeeList.DataSource = list;
                dgvEmployeeList.Columns.Remove("Password");
                txtUserID.Text = "";
                txtUserName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtRoleID.Text = "";
            }
        }
        private void ManageEmployee_Load(object sender, System.EventArgs e)
        {
            LoadEmployee();
        }
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            this.Hide();
            formAddEmployee.Show();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            LoadEmployee();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            bool check = userPresenter.DeleteEmployee();
            if (check)
            {
                LoadEmployee();
                MessageBox.Show("Delete successful!");
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            bool check = userPresenter.UpdateEmployee();
            if (check)
            {
                LoadEmployee();
                MessageBox.Show("Update successful!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployeeList.Rows[e.RowIndex];
                txtUserID.Text = row.Cells[0].Value.ToString();
                txtUserName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtRoleID.Text = row.Cells[5].Value.ToString();

            }
        }
    }
}
