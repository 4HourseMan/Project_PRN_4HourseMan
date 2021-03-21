using System;
using System.Windows.Forms;
using WinForms.Views;

namespace WinForms
{
    public partial class ManageSupllier : Form, ISupplierView
    {

        ManageSupplierPresenter _presenter;

        public ManageSupllier()
        {
            InitializeComponent();
            _presenter = new ManageSupplierPresenter(this);
        }

        public string SupID => txtSupplierID.Text;

        public string SupName => txtSupplierName.Text;

        public string Origin => txtSupplierOrigin.Text;

        public bool Status => chkSupplierStatus.Checked;

        public bool loadData()
        {
            bool check = true;
            try
            {
                dgvSupplier.DataSource = _presenter.GetSuppliers();
            }
            catch (Exception e)
            {
                check = false;
            }
            return check;
        }


    }
}
