using BusinessObjects;
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
    public partial class FormUpdateEmployee : Form, IUserView
    {
        public User user { get; set; }
        UserPresenter userPresenteer;

        public string UserID => txtUserID.Text.Trim();

        public string UserName => txtUserName.Text.Trim();

        public string Address => txtAddress.Text.Trim();

        public string Phone => txtPhone.Text.Trim();

        public string RoleID => "";

        public string Password => txtPassword.Text.Trim();

        public string Email => txtEmail.Text.Trim();

        public bool Status => RadioTrue.Checked ? true : false;

        public FormUpdateEmployee()
        {
            InitializeComponent();
            this.CenterToScreen();
            userPresenteer = new UserPresenter(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = userPresenteer.UpdateEmployee();
            if(check)
            {
                this.Hide();
                ManageEmployee manageEmployee = new ManageEmployee();
                manageEmployee.Show();
                MessageBox.Show("Update successful!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void FormUpdateEmployee_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = false;
            txtUserID.Text = user.UserID;
            txtUserName.Text = user.UserName;
            txtAddress.Text = user.Address;
            txtPhone.Text = user.Phone;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            
            if(RadioTrue.Text == user.Status.ToString())
            {
                RadioTrue.Checked = true;
            }
            else
            {
                RadioFalse.Checked = true;
            }

        }
    }
}
