namespace Lab6_3
{
    class Matrix3x3
    {
        private double[,] data;

        public Matrix3x3(double[,] data)
        {
            this.data = data;
        }

        public double this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }
    }
}
