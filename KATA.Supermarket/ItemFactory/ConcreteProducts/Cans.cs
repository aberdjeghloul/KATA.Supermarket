using System;

namespace KATA.Supermarket.ItemFactory
{
    /// <summary>
    /// Concrete class to create Cans available in my shop
    /// </summary>
    public class Cans : IItem
    {
        private decimal _price;
        private string _itemNumber;
        private string _name;

        public Cans(string name)
        {
            _name = name;
            GenerateItemNumber();
        }

        public string GetItemNumber()
        {
            return _itemNumber;
        }

        public string GetName()
        {
            return $"can of {_name}";
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }

        private void GenerateItemNumber()
        {
            _itemNumber = Guid.NewGuid().ToString();
        }
    }
}
