using Shapes;
using System;
using Xunit;

namespace ShapesTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0f)]
        [InlineData(-1f)]
        public void InvalidRadius_ThrowsArgumentException(float r) {
            Assert.Throws<ArgumentException>(() => new Circle(r));
        }
        [Theory]
        [InlineData(3.989423f, 50f)]
        [InlineData(28f, 2463.00864f)]
        [InlineData(1f, 3.14159)]
        [InlineData(0.08f, 0.020106f)]
        public void AreaCalculatesCorrectly(float r, float expected)
        {
            var c = new Circle(r);
            var actual = c.CalculateArea();
            Assert.Equal(expected, actual, 3);
        }
        [Fact]
        public void ShouldNotBeATriangle()
        {
            var c = new Circle(23);
            var expected = -1;
            var actual = c.IsRightAngled();
            Assert.Equal(expected, actual);
        }
    }
}
