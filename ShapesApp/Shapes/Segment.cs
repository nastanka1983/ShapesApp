namespace ShapesApp
{
    public class Segment: Shape
    {
        public float length;

        public Segment(float x, float y, float length) : base(x, y)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return $"Segment with coordinates:{x}, {y} and length {length}.";
        }
    }
}
