using System;
using System.Collections.Generic;
using System.Text;
using Shapes.Interfaces;

namespace Shapes.BaseImplement
{
    /// <summary>
    /// Implements the type of shape that is needed to initialize this shape.
    /// </summary>
    public readonly struct ShapeType : IShapeType
    {
        public ShapeType(string name)
        {
            Name = name;
        }
        public string Name { get; }
        /// <summary>
        /// Returns a new instance of the structure with a new specified parameter.
        /// </summary>
        /// <param name="replaceString"></param>
        /// <returns></returns>
        public ShapeType ReplaceTypeName(string replaceString)
        {
            if(!string.IsNullOrEmpty(replaceString))
            {
                return new ShapeType(replaceString);
            }
            return this;
        }
    }
}
