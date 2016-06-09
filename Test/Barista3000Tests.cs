using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Barista3000;
namespace UnitTestProject1
{
    [TestClass]
    public class Barista3000Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var coffeeMaker = new CoffeeMaker();

            coffeeMaker.MakeDrink(new SparklingWater());

            Assert.IsTrue(true, );
            //Assert.Equals("", );
        }
    }
}
