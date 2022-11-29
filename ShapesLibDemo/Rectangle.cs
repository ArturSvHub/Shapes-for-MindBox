using Shapes.BaseImplement;
using Shapes.Interfaces;

namespace ShapesLibDemo
{
    public class Rectangle : Shape
    {
        public override IShapeType Type { get; protected set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public Rectangle(double firstSide,double secondSide):base()
        {
            Type = new ShapeType(nameof(Rectangle));
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        public override double Square()
        {
            return FirstSide* SecondSide;
        }
        public override string ToString()
        {
            return $"Shape type - {nameof(Rectangle)}," +
                $" first side - {FirstSide}, " +
                $"second side - {SecondSide}, Square - {Math.Round(Square(), 2)}" ?? "";
        }
    }
}
