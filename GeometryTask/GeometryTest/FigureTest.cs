using Geometry;

namespace GeometryTest
{
    public class FigureTest
    {
        [Test] 
        public void InitFigureCircleTest()
        {
            Figure figure = new(0.5d);
            Assert.That(figure, Is.Not.Null);
        }

        [Test]
        public void InitFigureTriangleTest()
        {
            Figure figure = new(3, 4, 5);
            Assert.That(figure, Is.Not.Null);
        }
    }
}
