# Client test library for MindBox company

- Current version: netstandart 2.1
- There is coverage with NUnit tests
- During the development process, I tried to adhere to the SOLID principles
- All the wishes for the library have been made
- the type of triangle is found out automatically based on the source data

## Documentation:

### Registration
Add the following lines to the relevant sections of `Program.cs` or your custom shape class
```cs
using Shapes.BaseImplement;
```
If you want to create a new shape class, you need to inherit the abstract Shape class and override the necessary methods.
```cs
public class Rectangle : Shape
    {
        public override IShapeType Type { get; protected set; }
        
        public override double Square()
        {
            //TODO
        }
        public override string ToString() //IF NEEDED
        {
            return //TODO
        }
    }
```
By default, the shape type will be basic - Shape, if necessary, it can also be override. 
```cs
public override IShapeType Type { get; protected set; }
        public Rectangle():base()
        {
            Type = new ShapeType(nameof(Rectangle));
        }
```
Or
```cs
public override IShapeType Type { get; protected set; }
        public Rectangle():base()
        {
            Type = new ShapeType("My Shape");
        }
```
And the input data necessary for calculations can be added to the constructor.
```cs
public override IShapeType Type { get; protected set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public Rectangle(double firstSide,double secondSide):base()
        {
            Type = new ShapeType(nameof(Rectangle));
            FirstSide = firstSide;
            SecondSide = secondSide;
        }
```
-----------------------------------------------------------------------------------------------------


        
