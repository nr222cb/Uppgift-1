using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isIsoscelesTest_valid_param()
        {
            Triangle tri = new Triangle(1.2, 1.4, 1.2);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void isScaleneTest_valid_param()
        {
            Triangle tri = new Triangle(1.2, 1.4, 1.3);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        public void isEquilateralTest_valid_param()
        {
            Triangle tri = new Triangle(1.4, 1.4, 1.4);
            Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        public void isIsoscelesTest_with0()
        {
            try
            {
                Triangle tri = new Triangle(1.2, 0, 1.2);
                tri.isIsosceles();
                Assert.Fail("Should have exceptioned above!");
            }

            catch (System.ArgumentOutOfRangeException)
            {
                
            }
        }

        [TestMethod]
        public void isScaleneTest_with0()
        {
            try
            {
                Triangle tri = new Triangle(1.2, 0, 1.3);
                tri.isScalene();
                Assert.Fail("Should have exceptioned above!");
            }

            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        [TestMethod]
        public void isEquilateralTest_with0()
        {
            try
            {
                Triangle tri = new Triangle(0, 0, 0);
                tri.isEquilateral();
                Assert.Fail("Should have exceptioned above!");
            }

            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        [TestMethod]
        public void isScaleneTest_oneside_larger_thanthesumof2()
        {
            try
            {
                Triangle tri = new Triangle(1.2, 20, 1.3);
                tri.isScalene();
                Assert.Fail("Should have exceptioned above!");
            }

            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        [TestMethod]
        public void isIsoscelesTest_pointsConstructor()
        {
            Point punktA = new Point(1, 2);
            Point punktB = new Point(3, 4);
            Point punktC = new Point(3, 8);

            Triangle tri = new Triangle(punktA, punktB, punktC);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void isIsoscelesTest_pointsArrayConstructor()
        {
            Point punktA = new Point(1, 2);
            Point punktB = new Point(3, 4);
            Point punktC = new Point(3, 8);

            Point[] punkter = new Point[3];
            punkter[0] = punktA;
            punkter[1] = punktB;
            punkter[2] = punktC;

            Triangle tri = new Triangle(punkter);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void isIsoscelesTest_numericArrayConstructor()
        {
            double[] array = new double[3];
            array[0] = 1.2;
            array[1] = 1.4;
            array[2] = 1.2;

            Triangle tri = new Triangle(array);
            Assert.IsTrue(tri.isIsosceles());
        }
    }
}
