using System;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class Signup : Form, IUserView
    {
        UserPresenter userPresenter;
        public Signup()
        {
            InitializeComponent();
        }
        public string UserID => txtUserID.Text.Trim();
        public string UserName => txtUserName.Text.Trim();
        public string Address => txtAddress.Text.Trim();
        public string Phone => txtPhone.Text.Trim();
        public string RoleID => "EMP";
        public string Password => txtPassword.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        public bool Status => true;
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            userPresenter = new UserPresenter(this);
            bool check = userPresenter.InsertEmployee();
            if(check)
            {
                MessageBox.Show("Sign Up Successful!");
            }
            else
            {
                MessageBox.Show("Sign Up Fail!");
            }

        }
    }
}
