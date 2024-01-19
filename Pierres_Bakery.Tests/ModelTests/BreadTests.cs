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
        int ciabattaExpected = 3;
        Assert.AreEqual(sourdoughExpected, bread.SourdoughNum);
        Assert.AreEqual(focacciaExpected, bread.FocacciaNum);
        Assert.AreEqual(ciabattaExpected, bread.CiabattaNum);
    }

    [TestMethod]
    public void SettNum_SetsValueOfBreadNum_Void()
    {
        Bread bread = new(1, 2, 3);
        bread.SourdoughNum = 4;
        bread.FocacciaNum = 4;
        bread.CiabattaNum = 4;
        int expected = 4;
        Assert.AreEqual(expected, bread.SourdoughNum);
        Assert.AreEqual(expected, bread.FocacciaNum);
        Assert.AreEqual(expected, bread.CiabattaNum);
    }

    [TestMethod]
    public void CalculatePrice_CalculatesPriceOfSourdough_Int()
    {
        Bread bread = new(5, 4, 3);
        int expected = 20;
        Assert.AreEqual(expected, Bread.CalculatePrice(bread.SourdoughNum, 5, 3));
    }

}