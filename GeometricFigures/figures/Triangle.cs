namespace GeometricFigures
{
    public class Triangle : IFigure
    {
        public List<double> Sides { get; private set; }

        public double Square => IsRectangular 
            ? Sides[0] * Sides[1] / 2
            : Math.Sqrt(HalfPerimetr * (HalfPerimetr - Sides[0]) * (HalfPerimetr - Sides[1]) * (HalfPerimetr - Sides[2]));

        public double Perimeter => Sides.Sum();

        public double HalfPerimetr => Perimeter / 2;

        public bool IsRectangular => Math.Abs(Math.Pow(Sides[2], 2) 
            - Math.Pow(Sides[0], 2) 
            - Math.Pow(Sides[1], 2)) < 10e-5;

        public Triangle(double x , double y, double z)
        {
            Sides = new List<double> { x, y, z}
                .OrderBy(side => side)
                .ToList();

            if (!isTriangleExists())
            {
                throw new ArgumentException("Such triangle doesn't exists");
            }
        }

        private bool isTriangleExists()
        {
            return Sides[0] + Sides[1] > Sides[2] && Sides.Any(x => x > 0);
        }
    }
}
