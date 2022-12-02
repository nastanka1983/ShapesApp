namespace ShapesApp
{
    public class Rectangle : ShapeWithArea, IDrawable
    {
        public float height;
        public float width;

        public Rectangle(float x, float y, float height, float width) : base(x, y)
        {
            this.height = height;
            this.width = width;
        }

        public override float Area()
        {
            return height * width;
        }

        public void ColorShape(ShapeColor color)
        {
            Console.WriteLine($"Color the Rectangle {color} color an area of {Area()} cm.");
        }

        public void DrawLine(float dx, float dy)
        {
            Console.WriteLine($"Drawing line from {x + dx} to {y + dy}.");
        }

        public override string ToString()
        {
            return $"Rectangle with coordinates:{x}, {y}, height {height}, width {width}.";
        }
    }
}
