using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AdHome : Form
    {
        public AdHome()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
