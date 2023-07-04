using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel4Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 4, 0, 1 }, { -1, 2, -1 }, { 4, 1, 0 } };
            int[,] B = { { 2, 3,1 }, { 1, 2,5 }, { 2, -1,7 } };
            int[,] C = new int[3,3];
            int[,,] ucboyutludizi = new int[3,3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j]; 
                    }
                }
               
            }

            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C[i, j] + " ") ;
                }
                Console.Write("\n");
            }
        }
    }
}
