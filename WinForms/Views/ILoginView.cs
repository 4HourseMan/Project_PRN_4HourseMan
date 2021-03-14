namespace WinForms.Views
{
    public interface ILoginView : IView
    {
        string UserID { get; }
        string Password { get; }
    }
}
