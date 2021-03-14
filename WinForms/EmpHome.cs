using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class EmpHome : Form
    {
        public EmpHome()
        {
            InitializeComponent();
        }

        private void EmpHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
