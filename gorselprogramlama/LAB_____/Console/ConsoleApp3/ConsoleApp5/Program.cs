using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 4, 0, 1 }, { -1, 2, -1 } };
            int[,] B = { { 2,3 }, {1,2},{2,-1} };

            int[,] C = new int[A.GetLength(0), B.GetLength(1)];
            
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    int toplam=0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        int carpim = A[i, k] * B[k, j];
                        toplam = toplam+carpim;
                    }
                    C[i, j] = toplam;
                    Console.WriteLine(C[i,j]);
                }

            }
            
        }
    }
}
