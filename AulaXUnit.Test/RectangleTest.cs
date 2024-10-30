using AulaXUnit;

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
    }
}
