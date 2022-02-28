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
        protected override IItem CreateProduct()
        {
            IItem canOfBeans = new Cans("beans");
            canOfBeans.SetPrice(0.65m);
            return canOfBeans;
        }
    }
}
