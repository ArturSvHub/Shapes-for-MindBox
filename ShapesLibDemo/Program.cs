using Shapes.Implements;

namespace ShapesLibDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Circle(10);
            var tr = new Triangle(5, 4, 2);
            var rect = new Rectangle(10,20);
            Console.WriteLine(s);
            Console.WriteLine("\n");
            Console.WriteLine(tr);
            Console.WriteLine("\n");
            Console.WriteLine(rect);
            Console.WriteLine(tr.TriangleType);
        }
    }
}