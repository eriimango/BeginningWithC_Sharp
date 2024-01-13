namespace OOP;

// this program demonstrate simple class and object structures
public class Rectangle
{
    //fields
    private readonly double length;
    private readonly double width;

    //constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    //method
    public double GetArea()
    {
        return length * width;
    }

    private class Program
    {
        private static void Main()
        {
            var rect = new Rectangle(10.0, 20.0);
            Console.WriteLine("Area: " + rect.GetArea());
        }
    }
}