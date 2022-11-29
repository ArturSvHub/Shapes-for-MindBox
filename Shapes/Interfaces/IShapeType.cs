using Shapes.BaseImplement;

namespace Shapes.Interfaces
{
    public interface IShapeType
    {
        string Name { get; }
        ShapeType ReplaceTypeName(string replaceString);
    }
}