using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    public class CartComposite : ICartComposite
    {
        List<IItem> items = new List<IItem>();
        List<Discount> discounts = new List<Discount>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void AddDiscount(Discount discount)
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
            foreach(Discount discount in discounts)
            {
                total += discount.GetDiscountPrice();
            }

            return total;
        }
    }
}
