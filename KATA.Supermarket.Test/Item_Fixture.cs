using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATA.Supermarket.Test
{
    [TestClass]
    public class Item_Fixture
    {
        [TestMethod]
        public void Items_should_have_a_name_associated_to_it()
        {
            CansFactory cansFactory = new CansFactory();
            IItem canOfBeans = cansFactory.GetProduct();
            Assert.AreEqual<string>(canOfBeans.GetName(), "can of beans");            
        }

        [TestMethod]
        public void Items_should_have_a_price()
        {
            CansFactory cansFactory = new CansFactory();
            IItem canOfBeans = cansFactory.GetProduct();
            Assert.AreEqual<decimal>(canOfBeans.GetPrice(), 0.65m);
        }

        [TestMethod]
        public void Items_should_have_a_unique_itemnumber()
        {
            CansFactory cansFactory = new CansFactory();
            IItem canOfBeans1 = cansFactory.GetProduct();
            IItem canOfBeans2 = cansFactory.GetProduct();            
            Assert.IsFalse(canOfBeans1.GetItemNumber() == canOfBeans2.GetItemNumber());
        }
    }
}
