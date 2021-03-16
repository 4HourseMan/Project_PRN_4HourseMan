using System.Windows.Forms;
using WinForms.Views;

namespace WinForms
{
    public partial class ManageSupllier : Form,ISupplierView
    {
        public ManageSupllier()
        {
            InitializeComponent();
        }

        public string SupID => throw new System.NotImplementedException();

        public string SupName => throw new System.NotImplementedException();

        public string Origin => throw new System.NotImplementedException();

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
