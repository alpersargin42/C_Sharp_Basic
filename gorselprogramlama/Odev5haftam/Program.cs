using System;

namespace Odev5haftam
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[,] myfirstdizi = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] myseconddizi = new int[,] { { 3, 5, 6 }, { 7, 5, 5 }, { 6, 7, 10 } };
            int[,] newdeneme = new int[3, 3];
            newdeneme = MatrisCarp(myfirstdizi, myseconddizi);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(newdeneme[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
        }

        static int[,] MatrisCarp(int[,] myfirstdizi, int[,] myseconddizi)
        {
            int[,] mynewarray = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                       mynewarray[i, j] += myfirstdizi[i, k] * myseconddizi[k, j];
                    }

                }

            }
            return mynewarray;
        }
        
    }
}
