using BusinessObjects;
using System;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class Login : Form, ILoginView
    {
        private LoginPresenter loginPresenter;
        public Login()
        {
            InitializeComponent();
        }

        public string UserID
        {
            get { return txtUserID.Text.Trim(); }
        }

        public string Password
        {
            get { return txtPassword.Text.Trim(); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginPresenter = new LoginPresenter(this);
            User user = loginPresenter.Login();
            if (user.RoleID.Contains("AD"))
            {
                AdHome adHome = new AdHome();
                this.Hide();
                adHome.Show();
            }
        }
    }
}
