using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KATA.Supermarket.Test
{
    [TestClass]
    public class Item_Fixture
    {
        private IItem canOfBeans;
        private IItem canOfCorns;
        private CartComposite cart;
        public Item_Fixture()
        {
            CansFactory cansFactory = new CansFactory();
            canOfBeans = cansFactory.GetProduct("beans");
            canOfCorns = cansFactory.GetProduct("corns");
            cart = new CartComposite();
        }        

        [TestMethod]
        public void Items_should_have_a_name_associated_to_it()
        {   
            Assert.AreEqual<string>(canOfBeans.GetName(), "can of beans");            
        }        

        [TestMethod]
        public void Check_Price_Can_Beans()
        {
            Assert.AreEqual<decimal>(canOfBeans.GetPrice(), 0.65m);
        }

        [TestMethod]
        public void Check_Price_Can_Corns()
        {
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
            cart.AddItem(canOfBeans);
            cart.AddItem(canOfCorns);
            Assert.AreEqual<decimal>(cart.GetTotalPrice(), 1.5m);
        }

        [TestMethod]
        public void Discount_items_with_2()
        {
            Discount discount = new Discount(canOfBeans, 3, 1, 2);
            Assert.AreEqual<decimal>(discount.GetDiscountPrice(), 1.3m);
        }

        [TestMethod]
        public void Discount_items_with_4()
        {
            Discount discount = new Discount(canOfBeans, 3, 1, 4);
            Assert.AreEqual<decimal>(discount.GetDiscountPrice(), 1.33m);
        }

        [TestMethod]
        public void Discount_items_with_5()
        {
            Discount discount = new Discount(canOfBeans, 3, 1, 5);
            Assert.AreEqual<decimal>(discount.GetDiscountPrice(), 1.67m);
        }

        [TestMethod]
        public void Cart_calculate_total_sum_with_Items_and_Discount()
        {
            Discount discount = new Discount(canOfCorns, 3, 1, 4);
            cart.AddItem(canOfBeans);
            cart.AddDiscount(discount);
            Assert.AreEqual<decimal>(cart.GetTotalPrice(), 1.98m);
        }

        [TestMethod]
        public void Cart_calculate_total_sum_with_ConvertPrice_Discount_1_pound_1_99_Buy_4_onces()
        {
            ConvertPrice convertPrice = new ConvertPrice(1, "pound", 4, "once", 1.99m);
            cart.AddDiscount(convertPrice);
            Assert.AreEqual<decimal>(cart.GetTotalPrice(), 0.50m);
        }

        [TestMethod]
        public void Cart_calculate_total_sum_with_ConvertPrice_Discount_1_kg_1_99_Buy_600_g()
        {
            ConvertPrice convertPrice = new ConvertPrice(1, "kg", 600, "g", 1.99m);
            cart.AddDiscount(convertPrice);
            Assert.AreEqual<decimal>(cart.GetTotalPrice(), 1.19m);
        }

        [TestMethod]
        public void Cart_calculate_total_sum_with_ConvertPrice_Discount_1_kg_1_99_Buy_06_kg()
        {
            ConvertPrice convertPrice = new ConvertPrice(1, "kg", 0.6m, "kg", 1.99m);
            cart.AddDiscount(convertPrice);
            Assert.AreEqual<decimal>(cart.GetTotalPrice(), 1.19m);
        }
    }
}
