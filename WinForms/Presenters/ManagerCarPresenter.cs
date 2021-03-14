using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Models;
using BusinessObjects;

namespace WinForms.Presenters
{
    public class ManagerCarPresenter 
    {

        public void addProduct(Product p)
        {
            Model.AddProduct(p);
        }
    }
}
