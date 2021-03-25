using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class ManageOrder : Form, IManageOrderView
    {
        ManageOrderPresenter orderPresenter;

        int orderID = -1;
        public string userID { get; set; }
        public string OrderID => throw new NotImplementedException();

        public string UserID => throw new NotImplementedException();

        public string CusPhone => throw new NotImplementedException();

        public DateTime OrderDate => throw new NotImplementedException();

        public string Note => throw new NotImplementedException();

        public float TotalPrice => throw new NotImplementedException();

        public bool Status => throw new NotImplementedException();

        public ManageOrder()
        {
            InitializeComponent();
            this.CenterToScreen();
            orderPresenter = new ManageOrderPresenter(this);
        }
        private void LoadOrder()
        {
            List<Order> list = orderPresenter.GetAllOrder();
            tblOrder.DataSource = list;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormOrderDetail detail = new FormOrderDetail() { UID = userID};
            detail.Show();
        }


        private void ManageOrder_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void tblOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblOrder.Rows[e.RowIndex];
                orderID = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void ManageOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(orderID >= 0)
            {
                FormViewDetail viewDetail = new FormViewDetail() { OrderIDDetail = orderID };
                viewDetail.Show();
            }
            else
            {
                MessageBox.Show("Please choose an order to view");
            }
        }
    }
}
