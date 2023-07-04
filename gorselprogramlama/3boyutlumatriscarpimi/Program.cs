using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3boyutlumatriscarpimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] ucboyutludizi = new int[,,] { { { 4, 0, 1 }, { -1, 2, -1 }, { 4, 1, 0 }, { 2, 3, 1 }, { 1, 2, 5 }, { 2, -1, 7 } } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        ucboyutludizi[i,j,k] +=ucboyutludizi[j,i]*
                    }
                }

            }

        }

    }
}
