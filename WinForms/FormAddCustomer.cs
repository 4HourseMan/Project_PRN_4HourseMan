using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms
{
    public partial class FormAddCustomer : Form, IManageCustomerView
    {
        private ManageCustomerPresenter MCP;
        public FormAddCustomer()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string Phone => txtPhone.Text.Trim();

        public string CusName => txtCusName.Text.Trim();

        public string Email => txtEmail.Text.Trim();

        public string Address => txtAddress.Text.Trim();

        public string SearchPhone => throw new NotImplementedException();


        public bool CheckPhone(string phone)
        {
            bool check = true;
            try
            {
                if (phone.Length < 10)
                {
                    check = false;
                }
                else
                {
                    int alo = int.Parse(phone);
                    if(alo < 0)
                    {
                        check = false;
                    }
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Phone.Equals("") || CusName.Equals("") || Email.Equals("") || Address.Equals(""))
            {
                MessageBox.Show("Please fill all blank");
            }
            else
            {
                string err = "";
                if(!CheckPhone(Phone))
                {
                    err += "Phone is a string has 10 number.\n";
                }
                if (err.Equals(""))
                {
                    MCP = new ManageCustomerPresenter(this);
                    if (MCP.AddCustomer())
                    {
                        MessageBox.Show("Add success");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("This phone is exist");
                    }
                }
                else
                {
                    MessageBox.Show(err);
                }

            }
        }
    }
}
