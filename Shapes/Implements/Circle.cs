using Shapes.BaseImplement;
using Shapes.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Implements
{   /// <summary>
    /// Circle class, inherited from Shape class.
    /// </summary>
    public class Circle : Shape
    {
        public Circle(double radius) : base()
        {
            Type=new ShapeType(nameof(Circle));
            Radius= radius;
        }

        public double Radius { get; }

        public override IShapeType Type { get; protected set; }

        public override double Square()
        {
            return Math.PI*Math.Pow(Radius,2);
        }
        public override string ToString()
        {
            return $"Shape type - {nameof(Circle)}, radius - {Radius}"+$", Square - {Math.Round(Square(),2)}"??"";
        }
    }
}
