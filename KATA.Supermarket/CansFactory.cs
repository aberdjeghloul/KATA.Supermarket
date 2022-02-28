using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    /// <summary>
    /// Concrete class to builds cans
    /// </summary>
    public class CansFactory : ItemFactory
    {
        protected override IItem CreateProduct(string productName)
        {
            IItem canOfProducts = new Cans(productName);

            //Mock service to give price of each product
            if (productName == "beans")
                canOfProducts.SetPrice(0.65m);
            if (productName == "corns")
                canOfProducts.SetPrice(0.85m);
            
            return canOfProducts;
        }
    }
}
