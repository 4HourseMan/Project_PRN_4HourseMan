using BusinessObjects;
using System.Collections.Generic;

namespace WinForms.Models
{
    public interface IDetailModel
    {
        bool AddDetail(BusinessObjects.OrderDetail d);

        List<BusinessObjects.OrderDetail> GetDetail(int ID);
    }
}