using WinForms.Models;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class Presenter<T> where T : IView
    {
        protected static IModel Model { get; private set; }

        static Presenter()
        {
            Model = new Model();
        }

        protected T View { get; private set; }

        public Presenter(T view)
        {
            View = view;
        }
    }
}
