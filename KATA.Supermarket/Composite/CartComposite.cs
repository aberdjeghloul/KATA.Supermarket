using KATA.Supermarket.Discount;
using System.Collections.Generic;

namespace KATA.Supermarket.Composite
{
    public class CartComposite : ICartComposite
    {
        List<IItem> items = new List<IItem>();
        List<IDiscount> discounts = new List<IDiscount>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void AddDiscount(IDiscount discount)
        {            
            discounts.Add(discount);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;

            // Sum of items present in the cart without discount
            foreach(IItem item in items)
            {
                total += item.GetPrice();
            }

            //Sum of discount
            foreach(IDiscount discount in discounts)
            {
                total += discount.GetDiscountPrice();
            }

            return total;
        }
    }
}
