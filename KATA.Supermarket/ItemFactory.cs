using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    /// <summary>
    /// Abstract class to build Item
    /// </summary>
    public abstract class ItemFactory
    {
        protected abstract IItem CreateProduct();

        public IItem GetProduct()
        {
            return this.CreateProduct();
        }
    }
}
