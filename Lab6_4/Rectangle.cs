namespace Lab6_4
{
    class Rectangle : GraphicPrimitive
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Rectangle at ({X}, {Y}) with width {Width} and height {Height}");
        }

        public override void Scale(float factor)
        {
            Width = (int)(Width * factor);
            Height = (int)(Height * factor);
        }
    }
}
