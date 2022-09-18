namespace GeometricFigures
{
    public class Triangle : IFigure
    {
        public List<double> Sides { get; private set; }

        public bool isRectangular { get; private set; } = false;

        public double HalfPerimetr 
        { 
            get
            {
                return Sides.Sum() / 2;
            }  
        }

        public Triangle(double x , double y, double z)
        {
            Sides = new List<double>();
            Sides.Add(x);
            Sides.Add(y);
            Sides.Add(z);
            Sides.Sort();
            
            if (Math.Pow(Sides[2], 2) == Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2))
            {
                isRectangular = true;
            }

            if (!isTriangleExists())
            {
                throw new Exception("Such triangle doesn't exists");
            }
        }

        private bool isTriangleExists()
        {
            return Sides[0] + Sides[1] > Sides[2] && Sides.Any(x => x > 0);
        }


        public double FindSquare()
        {
            if (isRectangular)
            {
                return Sides[0] * Sides[1] / 2;
            }

            return Math.Sqrt(HalfPerimetr * (HalfPerimetr - Sides[0]) * (HalfPerimetr - Sides[1]) * (HalfPerimetr - Sides[2]));    
        }
    }
}
