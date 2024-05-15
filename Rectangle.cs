namespace GeometryLib
{
    public class Rectangle : IShape
    {
        public double Width { get;}
        public double Height { get;}

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new Exception("Rectangle parameters are less than or equal to zero");

            Width = width;
            Height = height;             
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimetr()
        {
            return (Width + Height) * 2;
        }
    }
}



