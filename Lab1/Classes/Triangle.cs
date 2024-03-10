namespace Lab1.Classes;

public class Triangle
{
    public double CalculateArea(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Długośi wszystkich boków muszą być większe od 0");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Z podanych długości nie można stworzyć trójkąta");

        var s = (a + b + c) / 2;


        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}