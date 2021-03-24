using BusinessObjects;
using BusinessObjects.DataAccess;
using System.Collections.Generic;

namespace WinForms.Models
{
    public class DetailModel : IDetailModel
    {
        private DetailData detail = new DetailData();
        public bool AddDetail(BusinessObjects.OrderDetail d)
        {
            return detail.AddDetail(d);
        }
        public List<BusinessObjects.OrderDetail> GetDetail(int ID)
        {
            return detail.GetDetail(ID);
        }
    }
}