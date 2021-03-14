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

        private void btnManagePro_Click(object sender, EventArgs e)
        {
            ManageCar car = new ManageCar();
            car.Show();
        }

        private void AdHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
