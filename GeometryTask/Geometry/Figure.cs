namespace Geometry
{
    public class Figure : IFigure
    {
        private readonly IFigure _figure;

        public Figure(double radius)
        {
            _figure = new Circle(radius);
        }

        public Figure(double a, double b, double c) 
        {
            _figure = new Triangle(a, b, c);
        }

        public double GetSquare()
        {
            return _figure.GetSquare();
        }
    }
}
