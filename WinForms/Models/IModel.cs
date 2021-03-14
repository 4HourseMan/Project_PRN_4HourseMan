using BusinessObjects;

namespace WinForms.Models
{
    public interface IModel
    {
        void AddProduct(Product p);

        User Login(string UserID, string Password);
    }
}
