using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otnosheniya
{
    class Graff
    {
        int[,] Matrix;
        int ver;
        public Graff(int[,] mtrx, int numer)
        {
            Matrix = mtrx;
            ver = numer;
        }
        public bool Prowerka()
        {
            bool bol = false;
            for (int i = 0; i < ver; i++)
                for (int j = 0; j < ver; j++)
                {
                    if (j > i)
                        if (Matrix[i, j] != Matrix[j, i] || (Matrix[i, j] != 0 && Matrix[i, j] != 1))
                        {
                            bol = true;
                        }
                }
            return bol;
        }
}
