using System;

namespace KATA.Supermarket.Discount
{
    public class DiscountNForX: IDiscount
    {
        public IItem Item { get; private set; }
        private readonly int numberOfItems;
        private readonly decimal packagePrice;
        private readonly int numberOfItemsToCalculatePriceFor;

        public DiscountNForX(IItem item, int numberOfItems, decimal packagePrice, int numberOfItemsToCalculatePriceFor)
        {
            Item = item;
            this.numberOfItems = numberOfItems;
            this.packagePrice = packagePrice;
            this.numberOfItemsToCalculatePriceFor = numberOfItemsToCalculatePriceFor;
        }

        public decimal GetDiscountPrice()
        {
            if (numberOfItemsToCalculatePriceFor < numberOfItems)
                return Math.Round(Item.GetPrice() * numberOfItemsToCalculatePriceFor, 2);
            decimal discountedPrice = decimal.Divide(numberOfItemsToCalculatePriceFor, numberOfItems) * packagePrice;
            return Math.Round(discountedPrice, 2);
        }
    }
}
