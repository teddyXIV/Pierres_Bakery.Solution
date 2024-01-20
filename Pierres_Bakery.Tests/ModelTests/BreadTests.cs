using Pierres_Bakery.Models;

namespace Pierres_Bakery.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
        Bread bread = new(1, 2, 3);
        Assert.AreEqual(typeof(Bread), bread.GetType());

    }

    [TestMethod]
    public void GetNum_ReturnsValueOfBreadNum_Int()
    {
        Bread bread = new(1, 2, 3);
        int sourdoughExpected = 1;
        int focacciaExpected = 2;
        int RyeExpected = 3;
        Assert.AreEqual(sourdoughExpected, bread.SourdoughNum);
        Assert.AreEqual(focacciaExpected, bread.FocacciaNum);
        Assert.AreEqual(RyeExpected, bread.RyeNum);
    }

    [TestMethod]
    public void SettNum_SetsValueOfBreadNum_Void()
    {
        Bread bread = new(1, 2, 3);
        bread.SourdoughNum = 4;
        bread.FocacciaNum = 4;
        bread.RyeNum = 4;
        int expected = 4;
        Assert.AreEqual(expected, bread.SourdoughNum);
        Assert.AreEqual(expected, bread.FocacciaNum);
        Assert.AreEqual(expected, bread.RyeNum);
    }

    [TestMethod]
    public void CalculatePrice_CalculatesPriceOfSourdough_Int()
    {
        Bread bread = new(5, 4, 3);
        int expected = 20;
        Assert.AreEqual(expected, Bread.CalculatePrice(bread.SourdoughNum, 5, 3));
    }

    [TestMethod]
    public void CalculatePrice_CalculatesPriceOfFocacciaWithOverload_Float()
    {
        Bread bread = new(0, 8, 0);
        int expected = 26;
        Assert.AreEqual(expected, Bread.CalculatePrice(bread.FocacciaNum, 4, 4, 0.75f));
    }

}