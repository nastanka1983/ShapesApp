namespace ShapesApp
{
    public class Square : ShapeWithArea, IDrawable
    {
        public float width;
        public Square(float x, float y, float width) : base(x, y)
        {
            this.width = width;
        }

        public override float Area()
        {
            return width * width;
        }

        public void ColorShape(ShapeColor color)
        {
            Console.WriteLine($"Color the Square {color} color an area of {Area()} cm.");
        }

        public void DrawLine(float dx, float dy)
        {
            Console.WriteLine($"Drawing line from {x + dx} to {y + dy}.");
        }

        public override string ToString()
        {
            return $"Square with coordinates:{x}, {y}, width {width}.";
        }
    }
}
