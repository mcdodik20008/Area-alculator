using AreaCalculator;
using AreaCalculator.figure;
using NUnit.Framework.Legacy;

namespace AreaCalculatorTest
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AreaCircle()
        {
            Circle circle = new(1);
            double area = calculator.CalculateArea(circle);

            ClassicAssert.AreEqual(area, Math.PI, 0.0001);
        }

        [Test]
        public void AreaTriangle()
        {
            Triangle triangle = new(13, 14, 15);
            double area = calculator.CalculateArea(triangle);
            Console.WriteLine(triangle.GetArea());
            ClassicAssert.AreEqual(area, 84, 0.0001);
        }

        [Test]
        public void IsntCorrectTriangle()
        {
            Triangle triangle = new(5, 5, 5);
            ClassicAssert.IsFalse(triangle.IsCorrect());
            double area = calculator.CalculateArea(triangle);
            Console.WriteLine(triangle.GetArea());
            Assert.Throws<InvalidOperationException>(() => throw new InvalidOperationException());
        }

        [Test]
        public void RightTriangle()
        {
            Triangle circle = new(3, 4, 5);
            ClassicAssert.IsTrue(circle.IsRightTriangle());
        }
    }
}