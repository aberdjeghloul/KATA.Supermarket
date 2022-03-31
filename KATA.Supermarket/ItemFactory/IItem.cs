
namespace KATA.Supermarket
{
    public interface IItem
    {
        string GetName();
        string GetItemNumber();
        void SetPrice(decimal price);
        decimal GetPrice();
    }
}
