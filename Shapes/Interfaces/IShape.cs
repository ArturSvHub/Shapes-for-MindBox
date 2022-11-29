using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Interfaces
{
    /// <summary>
    /// this interface is only for use in the current build 
    /// to extend the functionality of this library. 
    /// Outside of the library, inherit from the abstract Shape class.
    /// </summary>
    internal interface IShape
    {
        IShapeType Type { get;}
        double Square();
    }
}
