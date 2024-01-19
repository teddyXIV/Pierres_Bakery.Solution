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
    }
}