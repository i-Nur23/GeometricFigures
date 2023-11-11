namespace GeometricFigures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        
        public double Square => Math.PI * Math.Pow(Radius, 2);

        public double Perimeter => 2 * Math.PI * Radius;

        public Circle(double radius)
        {
            Radius = radius;

            if (!isCircleExsists())
            {
                throw new ArgumentException("Such circle doesn't exist");
            }
        }

        private bool isCircleExsists()
        {
            return Radius > 0; 
        }
    }
}
