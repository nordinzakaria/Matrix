namespace MathTool
{ 
    public class Matrix
    {
        float[,] values;
        public int NRow
        {
          get { return values.GetLength(0); }
        }

        public int NCol
        {
            get { return values.GetLength(1); }
        }

        public Matrix() { }

        public Matrix(float[,] values)
        {
            this.values = values;
        }

        public Matrix(int nrow, int ncol)
        {
            values = new float[nrow,ncol];
        }

        public void Randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < NRow; i++) 
            {
                for (int j = 0; j < NCol; j++)
                    {
                        values[j, i] = rand.Next();
                    }
            }
        }

        public float Get(int row, int col)
        {
            return values[row,col];
        }

        public void Set(int row, int col, float val)
        {
            values[row, col] = val;
        }

        public Matrix Add(Matrix mat)
        {
            Matrix m = new Matrix(mat.NRow, mat.NCol);
            for (int j = 0; j < NRow; j++)
            {
                for (int k = 0; k < NCol; k++)
                {
                    m.Set(j, k, Get(j, k) + mat.Get(j, k));
                }
            }
            return m;
        }

        public Matrix Minus(Matrix mat)
        {
            Matrix m = new Matrix(mat.NRow, mat.NCol);
            for (int j = 0; j < NRow; j++)
            {
                for (int k = 0; k < NCol; k++)
                {
                    m.Set(j, k, Get(j, k) - mat.Get(j, k));
                }
            }
            return m;
        }
    }
}
