using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(40);
            Assert.AreEqual(40, square.Side);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksSide()
        {
            Square square = new Square(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksSidePositivity()
        {
            Square square = new Square(-1);
        }

        [TestMethod]
        public void TestScaleSquare200Percent()
        {
            Square square = new Square(15);
            square.Scale(200);
            Assert.AreEqual(30, square.Side);
        }

        [TestMethod]
        public void TestScaleSquare150Percent()
        {
            Square square = new Square(15);
            square.Scale(150);
            Assert.AreEqual((decimal)22.5, square.Side);
        }

        [TestMethod]
        public void TestScaleSquare100Percent()
        {
            Square square = new Square(15);
            square.Scale(100);
            Assert.AreEqual(15, square.Side);
        }

        [TestMethod]
        public void TestScaleSquare37Percent()
        {
            Square square = new Square(15);
            square.Scale(37);
            Assert.AreEqual((decimal)5.55, square.Side);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleSquare0Percent()
        {
            Square square = new Square(15);
            square.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleSquareToNegativePercent()
        {
            Square square = new Square(15);
            square.Scale(-5);
        }

        [TestMethod]
        public void TestSquareSidesCount()
        {
            Square square = new Square(15);
            Assert.AreEqual(4, square.SidesCount);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(5);
            Assert.AreEqual(25, square.Area());
        }

        [TestMethod]
        public void TestBiggerSquareArea()
        {
            Square square = new Square(250);
            Assert.AreEqual(1000, square.Perimeter());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(5);
            Assert.AreEqual(20, square.Perimeter());
        }

        [TestMethod]
        public void TestSquareColors()
        {
            Shape shape = new Square(5);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.FillColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.BorderColor);
        }



    }
}
