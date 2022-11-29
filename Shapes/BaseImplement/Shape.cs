using Shapes.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.BaseImplement
{
    /// <summary>
    /// Inherit from this class to create your own shapes
    /// </summary>
    public abstract class Shape : IShape
    {
        public abstract IShapeType Type { get; protected set; }

        public Shape()
        {
            Type = new ShapeType(nameof(Shape));
        }

        public abstract double Square();
        public override string ToString()
        {
            return $"Shape type - {nameof(Shape)}";
        }
    }
}
