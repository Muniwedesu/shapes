using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class Circle : Shape
    {
        public float R { get; }
        private float _area = 0;

        public Circle(float r)
        {
            this.R = r;
        }
        public override float CalculateArea()
        {
            if (this._area < 0)
                this._area = 3.14f * R * R;
            return this._area;
        }
    }
}
