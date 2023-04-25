using Geometry;
namespace GeometryTest
{
    public class CircleTest
    {
        [Test]
        public void InitCircleTest()
        {
            double radius = Math.PI;

            Circle circle = new(radius);

            Assert.That(circle, Is.Not.Null);
        }

        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0d));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-3.13d));
        }

        [Test]
        public void GetSquareTest()
        {
            double radius = 2.88d;

            Circle circle = new(radius);

            double expectedValue = Math.PI * Math.Pow(radius, 2d);
            double square = circle.GetSquare();

            Assert.That(square, Is.EqualTo(expectedValue));
        }
    }
}