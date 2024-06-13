namespace AreaCalculator.figure;

public class Circle : Body
{
    private double radius;

    public Circle(Double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(radius, 2) * Math.PI;
    }
}