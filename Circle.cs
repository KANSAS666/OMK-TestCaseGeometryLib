namespace GeometryLib
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Circle parameters are less than or equal to zero");
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
}



