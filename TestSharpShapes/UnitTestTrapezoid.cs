using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestTrapezoid
    {
        [TestMethod]
        public void TestTrapezoidConstructor()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(5, trapezoid.FirstBase);
            Assert.AreEqual(8, trapezoid.SecondBase);
            Assert.AreEqual(2, trapezoid.Altitude);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksFirstBase()
        {
            Trapezoid trapezoid = new Trapezoid(0, 8, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksSecondBase()
        {
            Trapezoid trapezoid = new Trapezoid(5, 0, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksAltitude()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksFirstBasePositivity()
        {
            Trapezoid trapezoid = new Trapezoid(-5, 8, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksSecondBasePositivity()
        {
            Trapezoid trapezoid = new Trapezoid(5, -8, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidConstructorSanityChecksAltitudePositivity()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, -2);
        }

        [TestMethod]
        public void TestScaleTrapezoid200Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(200);
            Assert.AreEqual((decimal)10, trapezoid.FirstBase);
            Assert.AreEqual((decimal)16, trapezoid.SecondBase);
            Assert.AreEqual((decimal)4, trapezoid.Altitude);

        }

        [TestMethod]
        public void TestScaleTrapezoid150Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(200);
            Assert.AreEqual((decimal)10, trapezoid.FirstBase);
            Assert.AreEqual((decimal)16, trapezoid.SecondBase);
            Assert.AreEqual((decimal)4, trapezoid.Altitude);

        }

        [TestMethod]
        public void TestScaleTrapezoid100Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(200);
            Assert.AreEqual((decimal)5, trapezoid.FirstBase);
            Assert.AreEqual((decimal)8, trapezoid.SecondBase);
            Assert.AreEqual((decimal)2, trapezoid.Altitude);

        }

        [TestMethod]
        public void TestScaleTrapezoid37Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(200);
            Assert.AreEqual((decimal)1.85, trapezoid.FirstBase);
            Assert.AreEqual((decimal)2.96, trapezoid.SecondBase);
            Assert.AreEqual((decimal)0.74, trapezoid.Altitude);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleTrapezoid0Percent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleTrapezoidToNegativePercent()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            trapezoid.Scale(-5);
        }

        [TestMethod]
        public void TestTrapezoidSidesCount()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(4, trapezoid.SidesCount);
        }

        [TestMethod]
        public void TestTrapezoidArea()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual((decimal)13, trapezoid.Area());
        }

        [TestMethod]
        public void TestBiggerTrapezoidArea()
        {
            Trapezoid trapezoid = new Trapezoid(10, 16, 4);
            Assert.AreEqual((decimal)52, trapezoid.Area());
        }

        [TestMethod]
        public void TestTrapezoidPerimeter()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual((decimal)16.61, trapezoid.Area());
        }

        [TestMethod]
        public void TestTrapezoidColors()
        {
            Trapezoid trapezoid = new Trapezoid(5, 8, 2);
            Assert.AreEqual(System.Drawing.Color.Tomato, trapezoid.FillColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, trapezoid.BorderColor);
        }


    }
}
