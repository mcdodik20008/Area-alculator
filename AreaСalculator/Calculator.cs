using AreaCalculator.figure;

namespace AreaCalculator;

public class Calculator
{
    public double CalculateArea(Body body)
    {
        return body.GetArea();
    }

    public double CalculateAreaCircleByRadius(double radius)
    {
        Circle circle = new(radius);
        return CalculateArea(circle);
    }

    public double CalculateAreaTriangleBySides(double a, double b, double c)
    {
        Triangle triangle = new(a, b, c);
        return CalculateArea(triangle);
    }
}

