using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    public class Triangle : Shape
    {
        private float _area = -1;
        private int _isRightAngled = -1;
        public List<float> Sides { get; }

        public Triangle(float a, float b, float c)
        {
            Sides = new List<float>() { a, b, c };
            Sides.Sort();                       //assuming we always have 3 sides, the last element will always be a hypotenuse
            if (Sides[0] + Sides[1] < Sides[2]) //triangle inequality theorem/axiom
                throw new ArgumentException("Invalid parameters (sum of two sides' lengths must be greater than length of the third)");
        }

        public override float CalculateArea()
        {
            if (_area < 0)
            {
                float s = Sides.Aggregate(0f, (acc, x) => acc + x) / 2;
                _area = MathF.Sqrt(Sides.Aggregate(s, (acc, x) => acc * (s - x)));
            }
            return _area;
        }

        public override int IsRightAngled()
        {   
            if (_isRightAngled < 0)
            {   
                if (Math.Abs
                    ( Sides[1] * Sides[1]
                    + Sides[0] * Sides[0]
                    - Sides[2] * Sides[2])
                    < 0.01) //0.01 is our epsilon value for comparison
                    _isRightAngled = 1;
                else _isRightAngled = 0;
            }
            return _isRightAngled;
        }
    }
}

