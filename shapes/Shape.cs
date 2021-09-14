using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public abstract class Shape
    {
        public abstract float CalculateArea();
        public virtual int IsRightAngled()
        {
            // -1 means "this is not a triangle"
            return -1;
        }
    }
}
