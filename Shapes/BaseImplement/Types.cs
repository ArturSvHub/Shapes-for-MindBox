using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.BaseImplement
{
    public struct Types:ITypes
    {
        public List<IShapeType> ShapeTypes { get; }
        public Types(IShapeType type)
        {
            ShapeTypes = new List<IShapeType> { type };
        }
        public ITypes AddType(IShapeType type)
        {
            if (type != null)
            {
                ShapeTypes.Add(type);
            }
            return this;
        }
        public ITypes RemoveType(IShapeType type)
        {
            if (type != null && ShapeTypes.Count >= 1)
            {
                ShapeTypes.Remove(type);
            }
            return this;
        }
    }
}
