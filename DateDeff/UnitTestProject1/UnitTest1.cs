using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string TestDate = "2.11.2020";
            int expected = 0;

            //act
            int actual = 0;
            //int actual = MyClass.DaysDifference(TestDate);
            

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
