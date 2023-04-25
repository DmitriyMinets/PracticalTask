namespace Geometry

{
    public class Triangle : ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRightTriangle => GetIsRightTriangle();

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Сторона не может быть быть меньши либо равной нулю.");
            }
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("У треугольника сумма двух любых сторон должна быть больше третьей");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetSquare()
        {
            double halpP = (SideA + SideB + SideC) / 2d;

            double square = Math.Sqrt(halpP * (halpP - SideA) * (halpP - SideB) * (halpP - SideC));

            return square;
        }

        private bool GetIsRightTriangle()
        {
            double maxSide = SideA, b = SideB, c = SideC;

            if (b - maxSide > 0)
                (b, maxSide) = (maxSide, b);
            if (c - maxSide > 0)
                (c, maxSide) = (maxSide, c);

            return Math.Pow(maxSide, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
        }
    }
}
