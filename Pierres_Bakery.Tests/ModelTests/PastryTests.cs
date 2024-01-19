using Pierres_Bakery.Models;

namespace Pierres_Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstancsOfPastryClass_Pastry()
        {
            Pastry pastry = new(1, 2, 3);
            Assert.AreEqual(typeof(Pastry), pastry.GetType());

        }

        [TestMethod]
        public void PastryGet_ReturnsNumValue_Int()
        {
            Pastry pastry = new(1, 2, 3);
            int donutExpected = 1;
            int croissantExpected = 2;
            int fritterExpected = 3;
            Assert.AreEqual(donutExpected, pastry.DonutNum);
            Assert.AreEqual(croissantExpected, pastry.CroissantNum);
            Assert.AreEqual(fritterExpected, pastry.FritterNum);
        }

        [TestMethod]
        public void PastrySet_SetsNumValue_Void()
        {
            Pastry pastry = new(1, 2, 3);
            pastry.DonutNum = 4;
            pastry.CroissantNum = 4;
            pastry.FritterNum = 4;
            int expected = 4;
            Assert.AreEqual(expected, pastry.DonutNum);
            Assert.AreEqual(expected, pastry.CroissantNum);
            Assert.AreEqual(expected, pastry.FritterNum);
        }

        [TestMethod]
        public void CalculatePrice_ReturnsPriceOfDonuts_Int()
        {
            Pastry pastry = new(8, 0, 0);
            int expected = 12;
            Assert.AreEqual(expected, Pastry.CalculatePrice(pastry.DonutNum, 2, 4));
        }

        [TestMethod]
        public void CalculatePrice_ReturnsCroissantOfOrder_Float()
        {
            Pastry pastry = new(0, 2, 0);
            float expected = 6;
            Assert.AreEqual(expected, Pastry.CalculatePrice(pastry.CroissantNum, 4, 2, 0.5f));
        }

    }
}