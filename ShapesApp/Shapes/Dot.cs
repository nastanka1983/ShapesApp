namespace ShapesApp
{
    public class Dot : Shape
    {
        public Dot(float x, float y) : base(x, y)
        {
        }

        public override string ToString()
        {
            return $"Dot with coordinates:{x}, {y}";
        }
    }
}
