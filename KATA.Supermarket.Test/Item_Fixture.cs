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
    }
}
