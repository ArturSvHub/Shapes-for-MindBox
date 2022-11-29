using Shapes.Implements;

namespace Shapes.NTests
{
    public class TriangleTests
    {
        Triangle t = new Triangle(10, 15, 10);
        Triangle te = new Triangle(10, 10, 10);
        Triangle tr = new Triangle(3, 4, 5);
        [Test]
        public void ShouldSetTypeOfTriangle()
        {
            const string expected = "Triangle";
            Assert.That(t.Type.Name, Is.EqualTo(expected));
        }
        [Test]
        public void ShouldSetTriangleTypeSpecific_AreEquals_Isosceles()
        {
            const string expected = "Isosceles triangle";
            Assert.That(t.TriangleType, Is.EqualTo(expected));
        }
        [Test]
        public void ShouldSetTriangleTypeSpecific_AreEquals_Equilateral()
        {
            const string expected = "Equilateral triangle";
            Assert.That(te.TriangleType, Is.EqualTo(expected));
        }
        [Test]
        public void ShouldSetTriangleTypeSpecific_AreEquals_Right()
        {
            const string expected = "Right triangle";
            Assert.That(tr.TriangleType, Is.EqualTo(expected));
        }
        [Test]
        public void Square_Of_Triangle_10_15_10_AreEquals_4960()
        {
            const double expected = 49.60;
            double delta = 0.01;
            Assert.That(t.Square(), Is.EqualTo(expected).Within(0.01));
        }
        [Test]
        public void Square_Of_Triangle_10_10_10_AreEquals_4330()
        {
            const double expected = 43.30;
            double delta = 0.01;
            Assert.That(te.Square(), Is.EqualTo(expected).Within(0.01));
        }
        [Test]
        public void Square_Of_Triangle_3_4_5_AreEquals_6()
        {
            const double expected = 6;
            double delta = 0.01;
            Assert.That(tr.Square(), Is.EqualTo(expected).Within(0.01));
        }
        [Test]
        public void ShouldTriangleException_TheSumSides()
        {
            string message = "One of the sides of the triangle is greater than the sum of the other two. Correct the values.";
            ArgumentException ex = Assert.Throws<ArgumentException>(
                delegate { var z = new Triangle(1,100,5); });
            Assert.That(ex.Message,Is.EqualTo(message));
        }
        [Test]
        public void ShouldTriangleExceptionBelowZero()
        {
            string message = "None of the sides of the triangle can be less than or equal to zero.";
            ArgumentException ex = Assert.Throws<ArgumentException>(
                delegate { var z = new Triangle(-1, 1, 1 ); });
            Assert.That(ex.Message, Is.EqualTo(message));
        }
    }
}