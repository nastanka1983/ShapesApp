namespace ShapesApp
{
    public class Circle : ShapeWithArea, IDrawable
    {
        public float radius;

        public Circle(float x, float y, float r) : base(x, y)
        {
            this.radius = r;
        }

        public override float Area()
        {
            return (float)(radius *radius * Math.PI);
        }

        public void ColorShape(ShapeColor color)
        {
            Console.WriteLine($"Color the Circle {color} color an area of {Area()} cm.");
        }

        public void DrawLine(float dx, float dy)
        {
            Console.WriteLine($"Drawing line from {x+dx} to {y+dy}.");
        }
    }
}
