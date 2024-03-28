// See https://aka.ms/new-console-template for more information
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle();
        circle.Draw();

        var rectangle = new Rectangle();
        rectangle.Draw();

        var triangle = new Triangle();
        triangle.Draw();
    }
}
