using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class TimesInArrayTest
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] SomeArray = { 1, 3, 6, 3, 67, 8, 4, 6, 3, 7, 8, 3, 5, 6 };
        int result = TimesInArray.SearchFor(67, SomeArray);
        Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void TestMethod2()
    {
        int[] SomeArray = { 1, 3, 6, 3, 67, 8, 4, 6, 3, 7, 8, 3, 5, 6 };
        int result = TimesInArray.SearchFor(6, SomeArray);
        Assert.AreEqual(3, result);
    }
    [TestMethod]
    public void TestMethod3()
    {
        int[] SomeArray = { 1, 3, 6, 3, 67, 8, 4, 6, 3, 7, 8, 3, 5, 6 };
        int result = TimesInArray.SearchFor(3, SomeArray);
        Assert.AreEqual(4, result);
    }
}
