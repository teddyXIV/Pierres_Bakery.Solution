using Pierres_Bakery.Models;

namespace Pierres_Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstancsOfPastryClass_Pastry()
        {
            Pastry pastry = new(1, 2);
            Assert.AreEqual(typeof(Pastry), pastry.GetType());

        }

        [TestMethod]
        public void PastryGet_ReturnsNumValue_Int()
        {
            Pastry pastry = new(1, 2);
            int donutExpected = 1;
            int croissantExpected = 2;
            Assert.AreEqual(donutExpected, pastry.DonutNum);
            Assert.AreEqual(croissantExpected, pastry.CroissantNum);
        }

        [TestMethod]
        public void PastrySet_SetsNumValue_Void()
        {
            Pastry pastry = new(1, 2);
            pastry.DonutNum = 4;
            pastry.CroissantNum = 4;
            int expected = 4;
            Assert.AreEqual(expected, pastry.DonutNum);
            Assert.AreEqual(expected, pastry.CroissantNum);
        }

        [TestMethod]
        public void CalculatePrice_ReturnsPriceOfDonuts_Int()
        {
            Pastry pastry = new(8, 0);
            int expected = 12;
            Assert.AreEqual(expected, Pastry.CalculatePrice(pastry.DonutNum, 2, 4));
        }

        [TestMethod]
        public void CalculatePrice_ReturnsCroissantOfOrder_Float()
        {
            Pastry pastry = new(0, 2);
            float expected = 6;
            Assert.AreEqual(expected, Pastry.CalculatePrice(pastry.CroissantNum, 4, 2, 0.5f));
        }

    }
}