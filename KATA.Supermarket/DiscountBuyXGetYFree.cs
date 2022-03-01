using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    public class DiscountBuyXGetYFree : IDiscount
    {
        public IItem Item { get; private set; }
        private readonly int numberOfItemsToBuyX;
        private readonly int numberOfItemsToHaveFreeY;        

        public DiscountBuyXGetYFree(IItem item, int numberOfItemsToBuyX, int numberOfItemsToHaveFreeY)
        {
            Item = item;
            this.numberOfItemsToBuyX = numberOfItemsToBuyX;
            this.numberOfItemsToHaveFreeY = numberOfItemsToHaveFreeY;
        }

        public decimal GetDiscountPrice()
        {
            decimal itemPrice = Item.GetPrice();
            if (numberOfItemsToHaveFreeY > numberOfItemsToBuyX)
                return itemPrice * numberOfItemsToBuyX;
            return (itemPrice * numberOfItemsToBuyX) - (itemPrice * numberOfItemsToHaveFreeY);
        }
    }
}
