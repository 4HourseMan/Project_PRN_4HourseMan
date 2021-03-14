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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
