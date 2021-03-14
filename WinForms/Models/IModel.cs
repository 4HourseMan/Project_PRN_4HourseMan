using BusinessObjects;

namespace WinForms.Models
{
    public interface IModel
    {
        User Login(string UserID, string Password);
    }
}
