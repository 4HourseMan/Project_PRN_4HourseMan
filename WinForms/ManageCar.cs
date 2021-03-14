using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ManageCar : Form
    {
        public ManageCar()
        {
            InitializeComponent();
        }

        private void ManageCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddProduct pop = new FormAddProduct();
            pop.Show();
        }

        private void ManageCar_Load(object sender, EventArgs e)
        {

        }
    }
}
