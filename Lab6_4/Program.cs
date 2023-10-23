using Lab6_4;

class Program
{
    static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();

        Circle circle = new Circle { X = 10, Y = 10, Radius = 5 };
        Rectangle rectangle = new Rectangle { X = 20, Y = 20, Width = 10, Height = 15 };
        Triangle triangle = new Triangle { X = 30, Y = 30 };

        editor.AddPrimitive(circle);
        editor.AddPrimitive(rectangle);
        editor.AddPrimitive(triangle);

        Console.WriteLine("Drawing all primitives:");
        editor.DrawPrimitives();

        editor.MoveAllPrimitives(5, 5);

        Console.WriteLine("\nAfter moving all primitives:");
        editor.DrawPrimitives();

        circle.Scale(2);
        rectangle.Scale(1.5f);

        Console.WriteLine("\nAfter scaling circle and rectangle:");
        editor.DrawPrimitives();

        Group group = new Group { X = 40, Y = 40 };
        group.AddPrimitive(circle);
        group.AddPrimitive(rectangle);

        editor.AddPrimitive(group);

        Console.WriteLine("\nDrawing all primitives after adding a group:");
        editor.DrawPrimitives();

        editor.MoveAllPrimitives(10, 10);

        Console.WriteLine("\nAfter moving all primitives again:");
        editor.DrawPrimitives();
    }
}