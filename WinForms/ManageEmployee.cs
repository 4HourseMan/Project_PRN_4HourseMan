using BusinessObjects;
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
        public string UserName => txtUserNameSearch.Text.Trim();
        public string Address => txtAddress.Text.Trim();
        public string Phone => txtPhone.Text.Trim();
        public string RoleID => "EMP";
        public string Password => txtPassword.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        public bool Status => RadioTrue.Checked ? true : false;
        public ManageEmployee()
        {
            InitializeComponent();
            this.CenterToScreen();
            userPresenter = new UserPresenter(this);
        }
        public void LoadEmployee()
        {
            List<User> list = userPresenter.GetAllEmployee();
            if (list.Count == 0)
            {
                MessageBox.Show("This employee'name doesn't exist!");
            }
            else
            {
                txtUserID.Enabled = false;
                txtUserName.Enabled = false;
                txtAddress.Enabled = false;
                txtPhone.Enabled = false;
                txtPassword.Enabled = false;
                txtEmail.Enabled = false;
                txtRoleID.Enabled = false;
                RadioTrue.Enabled = false;
                RadioFalse.Enabled = false;

                dgvEmployeeList.DataSource = list;
                txtUserID.DataBindings.Clear();
                txtUserName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtRoleID.DataBindings.Clear();
                txtUserID.DataBindings.Add("Text", list, "UserID");
                txtUserName.DataBindings.Add("Text", list, "UserName");
                txtAddress.DataBindings.Add("Text", list, "Address");
                txtPhone.DataBindings.Add("Text", list, "Phone");
                txtPassword.DataBindings.Add("Text", list, "Password");
                txtEmail.DataBindings.Add("Text", list, "Email");
                txtRoleID.DataBindings.Add("Text", list, "RoleID");
                dgvEmployeeList.ReadOnly = true;

                RadioTrue.DataBindings.Clear();
                var status = new Binding("Checked", list, "Status");
                status.Format += (s, args) => args.Value = ((bool)args.Value) == true;
                status.Parse += (s, args) => args.Value = (bool)args.Value ? true : false;
                RadioTrue.DataBindings.Add(status);
                RadioTrue.CheckedChanged += (s, args) => RadioFalse.Checked = !RadioTrue.Checked;
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
            User user = new User(UserID, txtUserName.Text, Email, Address, Phone, RoleID, Password, Status);
            FormUpdateEmployee formUpdateEmployee = new FormUpdateEmployee() { user = user };
            this.Hide();
            formUpdateEmployee.Show();
        }
    }
}
