using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Views;
using BusinessObjects;

namespace WinForms.Presenters
{
    public class ManagerCarPresenter : Presenter<IManagerCarView>
    {
        public ManagerCarPresenter(IManagerCarView view) : base(view)
        {
            
        }

        public void addProduct(Product p)
        {
            Model.addProduct(p);
        }
    }
}
