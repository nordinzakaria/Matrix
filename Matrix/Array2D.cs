using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool
{
    public class Array2D
    {
        protected float[,] values;
        public int NRow
        {
            get { return values.GetLength(0); }
        }

        public int NCol
        {
            get { return values.GetLength(1); }
        }

        public Array2D() { }

        public Array2D(float[,] values)
        {
            this.values = values;
        }

        public Array2D(int nrow, int ncol)
        {
            values = new float[nrow, ncol];
        }

        public void Copy(Array2D array)
        {
            for (int i = 0; i < NRow; i++)
            {
                for (int j = 0; j < NCol; j++)
                {
                    values[j, i] = array.Get(j, i);
                }
            }
        }

        public void Resize(int nrow, int ncol)
        {
            values = new float[nrow, ncol];
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
            return values[row, col];
        }

        public void Set(int row, int col, float val)
        {
            values[row, col] = val;
        }

    }
}
