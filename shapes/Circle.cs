using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public float R { get; }
        private float _area = -1;

        public Circle(float r)
        {
            if (r <= 0) throw new ArgumentException();
            R = r;
        }
        public override float CalculateArea()
        {
            if (_area < 0)
                _area = MathF.PI * R * R;
            return _area;
        }
    }
}
