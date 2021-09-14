using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Triangle : Shape
    {
        private float _area = 0;
        private int _isRightAngled = -1;
        public List<float> Sides { get; }

        public Triangle(float a, float b, float c)
        {
            this.Sides = new List<float>() { a, b, c };
            //assuming we always have 3 sides, the last element will always be a hypotenuse
            this.Sides.Sort();
            //triangle inequality thing
            if (Sides[0] + Sides[1] < Sides[2]) throw new ArgumentException("Params");
        }

        public override float CalculateArea()
        {   //not using prop for no reason
            if (this._area == 0)
            {
                float s = Sides.Aggregate(0f, (acc, x) => acc + x) / 2;
                this._area = MathF.Sqrt(Sides.Aggregate(s, (acc, x) => acc * (s - x)));
            }
            return this._area;
        }

        public override int IsRightAngled()
        {   //Math.pow won't be more readable anyway
            if (this._isRightAngled < 0)
            {
                if (Sides[1] * Sides[1] + Sides[0] * Sides[0] == Sides[2] * Sides[2]) this._isRightAngled = 1;
                else this._isRightAngled = 0;
            }
            return this._isRightAngled;
        }
    }
}
