using System;
using System.Collections.Generic;
using System.Linq;

namespace shapes
{
    public class AreaCalculator
    {
        public float GetArea(Shape shape)
        {
            return shape.CalculateArea();
        }

        public bool IsRightAngled(Shape shape)
        {
            //this could return an object or ints, but...
            //if (shape.IsRightAngled() == -1) return "This is not a triangle";
            if (shape.IsRightAngled() == 1) return true;
            return false;
        }
    }


}
