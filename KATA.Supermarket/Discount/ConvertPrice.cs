using System;

namespace KATA.Supermarket.Discount
{
    public class ConvertPrice : IDiscount
    {
        private readonly decimal quantityInitial;
        private readonly string unitOriginal;
        private readonly decimal quantityPurchased;
        private readonly string unitPurchased;
        private readonly decimal packagePrice;
        public ConvertPrice(decimal quantityInitial, string unitOriginal, decimal quantityPurchased, string unitPurchased, decimal packagePrice)
        {
            this.quantityInitial = quantityInitial;
            this.unitOriginal = unitOriginal;
            this.quantityPurchased = quantityPurchased;
            this.unitPurchased = unitPurchased;
            this.packagePrice = packagePrice;
        }

        public decimal GetDiscountPrice()
        {            
            return Math.Round(decimal.Divide(ConvertQuantity(quantityPurchased, unitPurchased, unitOriginal) * packagePrice, quantityInitial), 2);
        }

        /// <summary>
        /// Mocking service. Convert only g to kg or once to pound
        /// </summary>
        /// <param name="quantity">Quantity you want convert. Ex 600 or 4</param>
        /// <param name="unitConvertFrom">unit from. Ex g or once</param>
        /// <param name="unitConvertTo">unit you want to convert quantity to. Ex kg or pound</param>
        /// <returns>quantity convert to. g=>kg or once=>pound. Another case return quantity itself</returns>
        private decimal ConvertQuantity(decimal quantity, string unitConvertFrom, string unitConvertTo)
        {
            if (unitConvertFrom == "g" && unitConvertTo == "kg")
                return quantity / 1000;

            if (unitConvertFrom == "once" && unitConvertTo == "pound")
                return quantity / 16;

            return quantity;
        }
    }
}
