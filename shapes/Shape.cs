namespace Shapes
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
