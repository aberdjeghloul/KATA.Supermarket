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
            IItem canOfBeans = cansFactory.GetProduct("beans");
            Assert.AreEqual<string>(canOfBeans.GetName(), "can of beans");            
        }        

        [TestMethod]
        public void Check_Price_Can_Beans()
        {
            CansFactory cansFactory = new CansFactory();
            IItem canOfBeans = cansFactory.GetProduct("beans");
            Assert.AreEqual<decimal>(canOfBeans.GetPrice(), 0.65m);
        }

        [TestMethod]
        public void Check_Price_Can_Corns()
        {
            CansFactory cansFactory = new CansFactory();
            IItem canOfCorns = cansFactory.GetProduct("corns");
            Assert.AreEqual<decimal>(canOfCorns.GetPrice(), 0.85m);
        }

        [TestMethod]
        public void Items_should_have_a_unique_itemnumber()
        {
            CansFactory cansFactory = new CansFactory();
            IItem canOfBeans1 = cansFactory.GetProduct("beans");
            IItem canOfBeans2 = cansFactory.GetProduct("beans");            
            Assert.IsFalse(canOfBeans1.GetItemNumber() == canOfBeans2.GetItemNumber());
        }
        
        [TestMethod]
        public void Cart_with_items_into_it_have_A_Total_Price()
        {
            CansFactory cansFactory = new CansFactory();
            IItem canOfBeans = cansFactory.GetProduct("beans");
            IItem canOfCorns = cansFactory.GetProduct("corns");
            CartComposite cart = new CartComposite();
            cart.AddItem(canOfBeans);
            cart.AddItem(canOfCorns);
            Assert.AreEqual<decimal>(cart.GetTotalPrice(), 1.5m);
        }
    }
}
