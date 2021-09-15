using shapes;
using System;
using Xunit;

namespace ShapesTests
{
    public class TriangleTests
    {   
        [Theory]
        [InlineData(7.356f, 10f, 13.434f, 0)]
        [InlineData(70f, 60f, 40f, 0)]
        [InlineData(4.63f, 4.1f, 6.23f, 0)]
        [InlineData(3, 4, 5, 1)]
        [InlineData(6.809f, 5.216f, 4.377f, 1)]
        [InlineData(4.169f, 6.23f, 4.63f, 1)]
        [InlineData(8f, 10f, 6f, 1)]
        [InlineData(8.2f, 10.28f, 6.2f, 1)]
        [InlineData(60.45f, 70.4345f, 36.15f, 1)]
        public void RightAngledDeterminesCorrectly(float a, float b, float c, int expected)
        {   //largely depends on all arguments' precision
            var t = new Triangle(a, b, c);
            var actual = t.IsRightAngled();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3f, 4f, 5f, 6f)]
        [InlineData(34f, 62f, 56f, 945.389f)]
        [InlineData(367f, 563f, 626, 102223.732f)]
        [InlineData(19.3495f, 33.2f, 23.594f, 224.219f)]
        public void AreaCalculatesCorrectly(float a, float b, float c, float expected)
        { 
            var t = new Triangle(a, b, c);
            var actual = t.CalculateArea();
            Assert.Equal(expected, actual, 2);
        }
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-1, 3.5f, 2)]
        [InlineData(0, 1, 2)]
        //[InlineData(32.24, 61, 42)] //this should fail
        public void InvalidSideSize_ThrowsArgumentException(float a, float b, float c)
        {
            Assert.Throws<ArgumentException>(()=> new Triangle(a,b,c));
        }
    }
}
