using BusinessObjects;
using BusinessObjects.DataAccess;

namespace WinForms.Models
{
    public class Model : IModel
    {

        User IModel.Login(string UserID, string Password)
        {
            UserData user = new UserData();
            return user.CheckLogin(UserID, Password);
        }
    }
}
