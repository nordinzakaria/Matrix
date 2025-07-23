using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool
{
    public class Matrix2D : Array2D, ISavable
    {
        public Matrix2D() : base() { }

        public Matrix2D(float[,] values): base(values) 
        {
        
        }

        public Matrix2D(Matrix2D mat) : base(mat.NRow, mat.NCol)
        {
            Copy(mat);
        }

        public Matrix2D(int nrow, int ncol): base(nrow, ncol) 
        { 
        
        }

        public Matrix2D Add(Matrix2D mat)
        {
            Matrix2D m = new Matrix2D(mat.NRow, mat.NCol);
            for (int j = 0; j < NRow; j++)
            {
                for (int k = 0; k < NCol; k++)
                {
                    m.Set(j, k, Get(j, k) + mat.Get(j, k));
                }
            }
            return m;
        }

        public Matrix2D Minus(Matrix2D mat)
        {
            Matrix2D m = new Matrix2D(mat.NRow, mat.NCol);
            for (int j = 0; j < NRow; j++)
            {
                for (int k = 0; k < NCol; k++)
                {
                    m.Set(j, k, Get(j, k) - mat.Get(j, k));
                }
            }
            return m;
        }

        public void Save(string fname)
        {
        }

    }
}
