using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tri = new Triangle(1.2, 0, 1.2);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void isScaleneTest()
        {
            Triangle tri = new Triangle(1.2, 0, 1.3);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle tri = new Triangle(0, 0, 0);
            Assert.IsTrue(tri.isEquilateral());
        }
    }
}
