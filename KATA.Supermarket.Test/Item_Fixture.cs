using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATA.Supermarket.Test
{
    [TestClass]
    public class Item_Fixture
    {
        [TestMethod]
        public void Items_should_have_a_name_associated_to_it()
        {
            Item item = new Item("can of beans");
            Assert.AreEqual<string>(item.GetName(), "can of beans");
        }

        [TestMethod]
        public void Items_should_have_a_unique_itemnumber()
        {
            Item item1 = new Item("can of beans");
            Item item2 = new Item("can of beans");
            Assert.IsFalse(item1.GetItemNumber() == item2.GetItemNumber());
        }
    }
}
