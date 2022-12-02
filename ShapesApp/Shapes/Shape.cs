namespace ShapesApp
{
    public abstract class Shape
    {
        protected float x;
        protected float y;

        protected Shape(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
