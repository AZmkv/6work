namespace Lab6_4
{
    class Group : GraphicPrimitive
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public override void Draw()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            base.Move(x, y);
            foreach (var primitive in primitives)
            {
                primitive.Move(x, y);
            }
        }
    }
}
