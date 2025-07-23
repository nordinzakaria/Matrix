using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool
{
    public class Image2D : Array2D, IDisplayable
    {
        public Image2D() : base() { }
        public Image2D(float[,] values) : base(values)
        {
        }
        public Image2D(int nrow, int ncol) : base(nrow, ncol)
        {
            for (int i = 0; i < nrow; i++)
                for (int j = 0; j < ncol; j++)
                    values[i, j] = 0;
        }
        public Image2D Brighten(float val)
        {
            Image2D m = new Image2D(NRow, NCol);
            for (int j = 0; j < NRow; j++)
            {
                for (int k = 0; k < NCol; k++)
                {
                    m.Set(j, k, Get(j, k) + val);
                }
            }
            return m;
        }

        public float Diff(Image2D mat)
        {
            float imgdiff = 0;
            for (int j = 0; j < NRow; j++)
            {
                for (int k = 0; k < NCol; k++)
                {
                    imgdiff += (float) Math.Abs(Get(j, k) - mat.Get(j, k));
                }
            }
            return imgdiff;
        }

        public void Display(string wintitle)
        {

        }
        }

}
