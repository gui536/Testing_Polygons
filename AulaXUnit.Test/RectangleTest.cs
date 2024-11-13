using AulaXUnit;
using Microsoft.AspNetCore.Components;
using System.Reflection;
using Xunit.Sdk;

namespace AulaXUnit.Test
{
    public class RectangleTest
    {
        [Fact]
        public void TestArea()
        {
            AulaXUnit.Rectangle rectangle = new AulaXUnit.Rectangle(2, 3);
            double ExpectedArea = 6;
            double ResultArea = rectangle.getArea();
            Assert.Equal(ExpectedArea, ResultArea);
        }
        [Fact]
        public void TestNullArea()
        {
            AulaXUnit.Rectangle rectangle = new AulaXUnit.Rectangle(0, 0);
            double ExpectedArea = 0;
            double ResultArea = rectangle.getArea();
            Assert.Equal(ExpectedArea, ResultArea);
        }
        [Fact]
        public void TestPerimeter()
        {
            AulaXUnit.Rectangle rectangle = new AulaXUnit.Rectangle(2, 3);
            double ExpectedPerimeter = 10;
            double ResultPerimeter = rectangle.getPerimeter();
            Assert.Equal(ExpectedPerimeter, ResultPerimeter);
        }
        [Fact]
        public void TestNullPerimeter()
        {
            AulaXUnit.Rectangle rectangle = new AulaXUnit.Rectangle(0, 0);
            double ExpectedArea = 0;
            double ResultPerimeter = rectangle.getArea();
            Assert.Equal(ExpectedArea, ResultPerimeter);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void TestPerimeter_for_integervalues(int value)
        {
            AulaXUnit.Rectangle rectangle = new AulaXUnit.Rectangle(value, value);
            double ExpectedPerimeter = value * 4;
            double ResultPerimeter = rectangle.getPerimeter();
            Assert.Equal(ExpectedPerimeter, ResultPerimeter);
        }
    }
}