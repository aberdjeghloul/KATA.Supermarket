using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    public class Discount
    {
        private readonly string itemName;
        private readonly int numberOfItems;
        private readonly int packagePrice;
                
        public Discount(IItem item, int numberOfItems, int packagePrice)
        {
            this.itemName = item.GetName();
            this.numberOfItems = numberOfItems;
            this.packagePrice = packagePrice;
        }

        public decimal GetDiscountPrice(int numberOfItemsToCalculatePriceFor)
        {
            decimal discountedPrice = Decimal.Divide(numberOfItemsToCalculatePriceFor, numberOfItems) * packagePrice;
            return Math.Round(discountedPrice, 2);
        }
    }
}
