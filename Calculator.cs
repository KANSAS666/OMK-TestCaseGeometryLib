namespace GeometryLib
{
    public class Calculator
    {
        private readonly ILogger _logger;
        
        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public double CalculateArea (IShape shape)
        {
            try
            {
                double area = shape.CalculateArea();
                _logger.Log("Successful calculation of the area");
                return area;
            }
            catch (Exception e)
            {
                _logger.Log("Error in calculate area: " + e.Message);
                throw;
            }
            
        }

        public double CalculatePerimetr(IShape shape)
        {
            try
            {
                double perimetr = shape.CalculatePerimetr();
                _logger.Log("Successful calculation of the perimetr");
                return perimetr;
            }
            catch (Exception e)
            {
                _logger.Log("Error in calculate perimetr: " + e.Message);
                throw;
            }
        }

    }
}



