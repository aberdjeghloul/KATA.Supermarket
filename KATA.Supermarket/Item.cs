using System;

namespace KATA.Supermarket
{
    public class Item
    {
        private string _name;
        private string _itemNumber;
        public Item(string name)
        {
            _name = name;
            GenerateItemNumber();
        }

        private void GenerateItemNumber()
        {
            _itemNumber = Guid.NewGuid().ToString();
        }

        public string GetName()
        {
            return _name;
        }

        public string GetItemNumber()
        {
            return _itemNumber;
        }
    }
}
