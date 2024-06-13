namespace AreaCalculator.figure;

public class Triangle : Body
{
    private double[] sides;

    public Triangle(double a, double b, double c)
    {
        sides = [a, b, c];
        // Сортируем для того, чтоб было понятно где вероятная гипотенуза, а где две стороны.
        Array.Sort(sides);
    }

    public override double GetArea()
    {
        if (IsCorrect())
        {
            throw new InvalidOperationException("Невозможно рассчитать площадь треугольника - длинна одной стороны больше или равна сумме длин других сторон. \n");
        }

        if (IsRightTriangle())
        {
            return sides[0] * sides[1] / 2;
        }

        double p = GetSquare();
        double powArea = p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]);
        return Math.Sqrt(powArea);
    }

    /**
     * Сумма двух сторон меньше самой длинной 
     */
    private bool IsCorrect()
    {
        return sides[2] < sides[0] + sides[1];
    }

    /**
     * Прямоугольный, если сумма квадратов двух сторон == квадрату самой длинной стороны
     */
    private bool IsRightTriangle()
    {
        return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
    }

    /**
     * Расчет периметра треугольника
     */
    private double GetSquare()
    {
        return sides.Sum();
    }

}
