using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    public class Discount
    {
        private readonly decimal itemPrice;
        private readonly int numberOfItems;
        private readonly decimal packagePrice;
        private readonly int numberOfItemsToCalculatePriceFor;


        public Discount(IItem item, int numberOfItems, decimal packagePrice, int numberOfItemsToCalculatePriceFor)
        {
            this.itemPrice = item.GetPrice();
            this.numberOfItems = numberOfItems;
            this.packagePrice = packagePrice;
            this.numberOfItemsToCalculatePriceFor = numberOfItemsToCalculatePriceFor;
        }

        public decimal GetDiscountPrice()
        {
            if (numberOfItemsToCalculatePriceFor < numberOfItems)
                return Math.Round(itemPrice * numberOfItemsToCalculatePriceFor, 2);
            decimal discountedPrice = decimal.Divide(numberOfItemsToCalculatePriceFor, numberOfItems) * packagePrice;
            return Math.Round(discountedPrice, 2);
        }
    }
}
