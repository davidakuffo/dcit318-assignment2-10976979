// Abstract class
public abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea()}"); // Outputs the area of the circle
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}"); // Outputs the area of the rectangle
    }
}
