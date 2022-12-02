using ShapesApp;

Shape[] shapes = { 
    new Square( 1, 1, 5), 
    new Rectangle(10, 10, 4, 6), 
    new Triangle(20, 20, 3, 5, 7), 
    new Circle(30, 30, 8),
    new Dot(40, 40),
    new Segment(50, 50, 10)
};

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.ToString());
    if(shape is IDrawable)
    {
        (shape as IDrawable).ColorShape(ShapeColor.Green);
        (shape as IDrawable).DrawLine(2, 2);
    }
}

