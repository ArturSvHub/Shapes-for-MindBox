using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.BaseImplement
{
    /// <summary>
    /// If you want to create and manage a collection of your shape types, 
    /// you can implement the interface IType.
    /// </summary>
    public interface ITypes
    {
        List<IShapeType> ShapeTypes { get; }
        ITypes AddType(IShapeType type);
        ITypes RemoveType(IShapeType type);
    }
}
