/* Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively. */


Circle circle1 = new Circle(5);
Circle circle2 = new Circle(3);

Console.WriteLine($"Area of Circle 1: {circle1.Area:F2}");
Console.WriteLine($"Area of Circle 2: {circle2.Area:F2}");

Console.WriteLine($"Sum of Areas: {circle1 + circle2:F2}");
Console.WriteLine($"Difference of Areas: {circle1 - circle2:F2}");

class Circle
{
    public double Radius { get; set; }

    public double Area
    {
        get { return Math.PI * Radius * Radius; }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Overload + operator
    public static double operator +(Circle c1, Circle c2)
    {
        return c1.Area + c2.Area;
    }

    // Overload - operator
    public static double operator -(Circle c1, Circle c2)
    {
        return c1.Area - c2.Area;
    }
}
