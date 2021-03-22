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
        }

        public string SupID => txtSupplierID.Text;

        public string SupName => txtSupplierName.Text;

        public string Origin => txtSupplierOrigin.Text;

        public bool Status => chkSupplierStatus.Checked;

        public void loadData()
        {
            _presenter = new ManageSupplierPresenter(this);
            dgvSupplier.DataSource = _presenter.GetSuppliers();
        }

        private void ManageSupllier_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void ClearTextBox()
        {
            txtSupplierID.Clear();
            txtSupplierName.Clear();
            txtSupplierOrigin.Clear();
            chkSupplierStatus.Checked = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _presenter = new ManageSupplierPresenter(this);
            if (_presenter.InsertSupplier())
            {
                ShowMessage("Added Success");
            }
            else
            {
                ShowMessage("Failed to Add");
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _presenter = new ManageSupplierPresenter(this);
            if (_presenter.UpdateSupplier())
            {
                ShowMessage("Update Success");
            }
            else
            {
                ShowMessage("Failed to Update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter = new ManageSupplierPresenter(this);
            if (_presenter.DeleteSupplier())
            {
                ShowMessage("Delete Success");
            }
            else
            {
                ShowMessage("Failed to Delete");
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
            txtSupplierID.Text = row.Cells[0].Value.ToString();
            txtSupplierName.Text = row.Cells[1].Value.ToString();
            txtSupplierOrigin.Text = row.Cells[2].Value.ToString();
            chkSupplierStatus.Checked = Boolean.Parse(row.Cells[3].Value.ToString());
        }

        private void ManageSupllier_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
