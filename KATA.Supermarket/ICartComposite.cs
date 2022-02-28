using System;
using System.Collections.Generic;
using System.Text;

namespace KATA.Supermarket
{
    /// <summary>
    /// Cart composite with items into from my Grocery
    /// Each item have a price
    /// </summary>
    public interface ICartComposite
    {        
        decimal GetTotalPrice();
    }
}
