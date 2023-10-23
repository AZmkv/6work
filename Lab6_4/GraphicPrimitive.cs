namespace Lab6_4
{
    abstract class GraphicPrimitive
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();
        public virtual void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public virtual void Scale(float factor)
        {
            // Default implementation for scaling
        }
    }
}
