using System;

namespace ConsoleApp2
{
    class Program
    {
        //1 den 100 e kadar asal sayıları yazdırma
        static void Main(string[] args)
        {
            int sayi = 2;
            for (int i = sayi; i <= 100; i++)
            {
                for (int j = 2; j <=50; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(sayi);
                        break;
                    }
                }
                sayi++;
            }
        }
    }
}
