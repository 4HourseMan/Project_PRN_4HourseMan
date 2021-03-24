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
using WinForms.Views;

namespace WinForms
{
    public partial class FormAddEmployee : Form, IUserView
    {
        UserPresenter userPresenter;
        public FormAddEmployee()
        {
            InitializeComponent();
            this.CenterToScreen();
            userPresenter = new UserPresenter(this);
        }

        public string UserID => txtUserID.Text.Trim();

        public string UserName => txtUserName.Text.Trim();

        public string Address => txtAddress.Text.Trim();

        public string Phone => txtPhone.Text.Trim();

        public string RoleID => "EMP";

        public string Password => txtPassword.Text.Trim();

        public string Email => txtEmail.Text.Trim();

        public bool Status => true;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool check = userPresenter.InsertEmployee();
            if (check)
            {
                this.Hide();
                ManageEmployee manageEmployee = new ManageEmployee();
                manageEmployee.Show();
                MessageBox.Show("Add Employee Successful!");
            }else
            {
                MessageBox.Show("Add Employee Failed!");
            }
        }

        
    }
}
