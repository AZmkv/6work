namespace Lab6_4
{
    class Circle : GraphicPrimitive
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle at ({X}, {Y}) with radius {Radius}");
        }

        public override void Scale(float factor)
        {
            Radius = (int)(Radius * factor);
        }
    }

}
