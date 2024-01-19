using Pierres_Bakery.Models;

namespace Pierres_Bakery.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
        Bread bread = new(1);
        Assert.AreEqual(typeof(Bread), bread.GetType());

    }

    [TestMethod]
    public void GetNum_ReturnsValueOfBreadNum_Int()
    {
        Bread bread = new(1);
        int expected = 1;
        Assert.AreEqual(expected, bread.BreadNum);
    }

    [TestMethod]
    public void SettNum_SetsValueOfBreadNum_Void()
    {
        Bread bread = new(1);
        bread.BreadNum = 2;
        int expected = 2;
        Assert.AreEqual(expected, bread.BreadNum);
    }

    [TestMethod]
    public void CalculatePrice_CalculatesPriceOfOrder_Int()
    {
        Bread bread = new(5);
        int expected = 20;
        Assert.AreEqual(expected, bread.CalculatePrice(bread.BreadNum, 5, 3));
    }

}