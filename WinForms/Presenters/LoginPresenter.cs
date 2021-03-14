using BusinessObjects;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class LoginPresenter : Presenter<ILoginView>
    {
        public LoginPresenter(ILoginView view) : base(view) { }
        public User Login()
        {
            string UserID = View.UserID;
            string Password = View.Password;
            return Model.Login(UserID, Password);
        }
    }
}
