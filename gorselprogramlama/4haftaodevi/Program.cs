using System;

namespace _4haftaodevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myarray = new int[3, 3, 3] {
                { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                { { 11, 10, 9 }, { 4, 5, 6 }, { 7, 8, 9 } },
                { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }
            };
            int[,,] newdeneme = new int[3, 3,3];
            newdeneme = MatrisCarp(myarray);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(newdeneme[i, j, k]);
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }
            }
        }

        static int[,,] MatrisCarp(int[,,] myarray)
        {

            int[,,] array1 = new int[3, 3,3];
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        array1[2, k, i] += myarray[0, i, j] * myarray[1, j, i];
                    }

                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array1[2, i, j] = array1[2, i, j];
                    }
                    
                }
            }
            return array1;
        }

    }
}
