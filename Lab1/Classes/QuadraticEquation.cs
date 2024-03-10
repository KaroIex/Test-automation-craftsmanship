namespace Lab1.Classes;

public class QuadraticEquation
{
    public double[] Solve(double a, double b, double c)
    {
        if (a == 0)
            throw new ArgumentException("wspołczynnik 'a' nie może wynosić 0");

        var delta = b * b - 4 * a * c;

        if (delta < 0)
            return Array.Empty<double>();

        if (delta == 0)
            return new[] { -b / (2 * a) };

        var sqrtDelta = Math.Sqrt(delta);
        return new[]
        {
            (-b - sqrtDelta) / (2 * a),
            (-b + sqrtDelta) / (2 * a)
        };
    }
}