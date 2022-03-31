
namespace KATA.Supermarket.Composite
{
    /// <summary>
    /// Cart composite with items into from my Grocery
    /// Each item have a price
    /// </summary>
    public interface ICartComposite
    {        
        decimal GetTotalPrice();
    }
}
