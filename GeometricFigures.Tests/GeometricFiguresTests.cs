using NUnit.Framework;
using GeometricFigures;
using System;

namespace GeometricFigures.Tests
{
    [TestFixture]
    public class GeometricFiguresTests
    {
        [Test]
        public void HlafPerimetr_IsRight_ReturnsTrue()
        {
            var triangle = new Triangle(6, 8, 7);

            var halfPerimetr = triangle.HalfPerimetr;

            Assert.AreEqual(halfPerimetr, 10.5, 10e-10);
        }

        [TestCase(30, 2827.43339)]
        [TestCase(5, 78.53982)]
        [TestCase(3.67, 42.31380)]
        public void FindSquareCircle_RightValue_ReturnsTrue(double rad, double expected)
        {
            var circle = new Circle(rad);

            var square = circle.FindSquare();

            Assert.AreEqual(square, expected, 10e-5);
        }

        [TestCase(30,23,17, 194.42222)]
        [TestCase(5, 6, 9, 14.14213)]
        [TestCase(6.67, 6.8, 11.34, 20.60761)]
        public void FindSquareTriangle_RightValue_ReturnsTrue(double x, double y, double z, double expected)
        {
            var triangle = new Triangle(x,y,z);

            var square = triangle.FindSquare();

            Assert.AreEqual(square, expected, 10e-5);
        }

        [TestCase(3,4,5, true)]
        [TestCase(5, 8,6.245, true)]
        [TestCase(2, 4, 5, false)]
        public void isRectangular_RightState_RetrunsTrue(double x, double y, double z, bool expected)
        {
            var triangle = new Triangle(x, y, z);

            var isRect = triangle.isRectangular;

            Assert.AreEqual(isRect, expected);
        }

      
        [TestCase(33, 4, 5)]
        [TestCase(4, -6, 7)]
        public void Triangle_BadArguments_Throws(double x, double y, double z)
        {
            Triangle trinagle;

            Assert.Throws<ArgumentException>(() => trinagle = new Triangle(x,y,z));
        }

        [Test]
        public void Circle_BadArguments_Throws()
        {
            Circle circle;

            Assert.Throws<ArgumentException>(() => circle = new Circle(-5.6));
        }
    }
}