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
            dataGridView1.DataSource = list;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormOrderDetail detail = new FormOrderDetail();
            detail.Show();
        }


        private void ManageOrder_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
