using Pierres_Bakery.Models;

namespace Pierres_Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstancsOfPastryClass_Pastry()
        {
            Pastry pastry = new(1);
            Assert.AreEqual(typeof(Pastry), pastry.GetType());

        }

        [TestMethod]
        public void PastryGet_ReturnsNumValue_Int()
        {
            Pastry pastry = new(1);
            int expected = 1;
            Assert.AreEqual(expected, pastry.Num);
        }

        [TestMethod]
        public void PastrySet_SetsNumValue_Void()
        {
            Pastry pastry = new(1);
            pastry.Num = 2;
            int expected = 2;
            Assert.AreEqual(expected, pastry.Num);

        }
    }
}