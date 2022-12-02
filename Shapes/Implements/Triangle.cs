using Shapes.BaseImplement;
using Shapes.Interfaces;
using System;

namespace Shapes.Implements
{
    /// <summary>
    /// Triangle class, inherited from Shape class.
    /// </summary>
    public class Triangle : Shape
    {
        /// <value>
        /// The geometric type of the triangle.
        /// </value>
        public string TriangleType { get; }
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public override IShapeType Type { get; protected set; }

        public Triangle( double firstSide, double secondSide, double thirdSide) : base()
        {
            Type = new ShapeType(nameof(Triangle));
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            TriangleType = GetTriangleType();
        }
        /// <summary>
        /// Calculates the area of a triangle on three sides.
        /// </summary>
        /// <returns>double</returns>
        public override double Square()
        {
            double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(halfPerimeter
                * (halfPerimeter - FirstSide)
                * (halfPerimeter - SecondSide)
                * (halfPerimeter - ThirdSide));
        }
        /// <summary>
        /// Returns the type of triangle depending on its geometric properties.
        /// </summary>
        /// <returns>string</returns>
        /// <exception cref="ArgumentException"></exception>
        private string GetTriangleType()
        {
            double first = Math.Round(FirstSide, 2), second = Math.Round(SecondSide, 2), third = Math.Round(ThirdSide, 2);
            
            if(first<=0||second<=0||third<=0)
            {
                throw new ArgumentException("None of the sides of the triangle can be less than or equal to zero.");
            }
            else if ((first > (second + third)) || (second > (first + third)) || (third > (first + second)))
            {
                throw new ArgumentException("One of the sides of the triangle is greater than the sum of the other two. Correct the values.");
            }
            else if (first == second && second == third && first == third)
            {
                return "Equilateral triangle";
            }

            else if ((first == second && second != third && first != third) ||
                (first != second && second == third && first != third) ||
                (first != second && second != third && first == third))
            {
                return "Isosceles triangle";
            }

            else if ((Math.Pow(first, 2) == (Math.Pow(second, 2) + Math.Pow(third, 2))) ||
                (Math.Pow(second, 2) == (Math.Pow(first, 2) + Math.Pow(third, 2))) ||
                (Math.Pow(third, 2) == (Math.Pow(first, 2) + Math.Pow(second, 2))))
            {
                return "Right triangle";
            }

            else
            {
                return "The Versatile triangle";
            }
        }
        public override string ToString()
        {
            return $"Shape type - {nameof(Triangle)}, triangle type - {TriangleType}," +
                $" first side - {FirstSide}, " + 
                $"second side - {SecondSide}, third side - {ThirdSide}, Square - {Math.Round(Square(), 2)}" ?? "";
        }
    }
}
