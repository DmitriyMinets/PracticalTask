using Geometry;

namespace GeometryTest
{
    public class TriangleTest
    {
        [Test]
        public void InitTriangleTest()
        {
            double a = 3d, b = 4d, c = 5d;

            Triangle triangle = new(a, b, c);

            Assert.That(triangle, Is.Not.Null);
        }

        [TestCase(-2.05d, 4d, 5d)]
        [TestCase(2.05d, -4d, 5d)]
        [TestCase(2.05d, 4d, -5d)]
        [TestCase(0d, 4d, 5d)]
        [TestCase(2.05d, 0d, 5d)]
        [TestCase(2.05d, 4d, 0d)]
        public void ZeroOrNegativeSidesTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(2d, 2d, 5d)]
        [TestCase(2d, 5d, 2d)]
        [TestCase(5d, 2d, 2d)]
        public void NonExistentTriangleTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void GetSquareTest()
        {
            double a = 3d, b = 4d, c = 5d;
            double expectedValue = (a * b) / 2;

            Triangle triangle = new(a, b, c);

            double square = triangle.GetSquare();

            Assert.That(expectedValue, Is.EqualTo(square));
        }

        [TestCase(6d, 4d, 3d, ExpectedResult = false)]
        [TestCase(5d, 4d, 3d, ExpectedResult = true)]
        [TestCase(5.018d, 4d, 3d, ExpectedResult = false)]
        public bool GetIsRightTriangleTest(double a, double b, double c)
        {
            Triangle triangle = new(a, b, c);

            bool isRight = triangle.IsRightTriangle;

            return isRight;
        }
    }
}