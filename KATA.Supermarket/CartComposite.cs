using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    public class CartComposite : ICartComposite
    {
        List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;

            foreach(IItem item in items)
            {
                total += item.GetPrice();
            }

            return total;
        }
    }
}
