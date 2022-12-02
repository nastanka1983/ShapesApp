namespace ShapesApp
{
    public class Triangle : ShapeWithArea, IDrawable
    {
        public float aSide;
        public float bSide;
        public float cSide;

        public Triangle(float x, float y, float a, float b, float c) : base(x, y)
        {
            aSide = a;
            bSide = b;
            cSide = c;
        }

        public override float Area()
        {
            float p = (float)(aSide + bSide + cSide) / 2 ;
            return (float)Math.Sqrt((double)(p * (p - aSide) * (p - bSide) * (p - cSide)));
        }

        public void ColorShape(ShapeColor color)
        {
            Console.WriteLine($"Color the Circle {color} color an area of {Area()} cm.");
        }

        public void DrawLine(float dx, float dy)
        {
            Console.WriteLine($"Drawing line from {x + dx} to {y + dy}.");
        }

        public override string ToString()
        {
            return $"Triangle with coordinates:{x}, {y}, A side {aSide}, B side {bSide}, C side {cSide}.";
        }
    }
}
