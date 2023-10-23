namespace Lab6_4
{
    class GraphicsEditor
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public void DrawPrimitives()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public void MoveAllPrimitives(int x, int y)
        {
            foreach (var primitive in primitives)
            {
                primitive.Move(x, y);
            }
        }
    }
}
