using NUnit.Framework;
using GeometricFigures;

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
        public void FindSquareCircle_RightValid_ReturnsTrue(double rad, double expected)
        {
            var circle = new Circle(rad);

            var square = circle.FindSquare();

            Assert.AreEqual(square, expected, 10e-5);
        }
    }
}