namespace WinForms.Views
{
    public interface IDetailOrderView : IView
    {
        int DetailID { get; }
        int OrderID { get; }
        string ProductID { get; }
        int Quantity { get; }
        float Price { get; }
    }
}