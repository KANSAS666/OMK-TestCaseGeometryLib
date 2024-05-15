namespace GeometryLib
{
    public class Square : IShape
    {
        public double SquareSide { get; }

        public Square(double squareSide)
        {
            if (squareSide <= 0)
                throw new Exception("Rectangle parameters are less than or equal to zero");

            SquareSide = squareSide;
        }

        public double CalculateArea()
        {
            return SquareSide * SquareSide;
        }

        public double CalculatePerimetr()
        {
            return SquareSide * 4;
        }
    }
}


