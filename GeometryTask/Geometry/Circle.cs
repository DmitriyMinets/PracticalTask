namespace Geometry
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Неверно указано значение радиуса", nameof(radius));
            }
            if (radius == 0)
            {
                throw new ArgumentException("Данная окружность является точкой (вырожденная окружность).", nameof(radius));
            }

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}