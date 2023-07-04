using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0;
            int toplam = 0;
            for (int i = 2; i <= 100; i++)
            {
                kontrol = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        kontrol++;
                    }
 
                }
                if (kontrol <= 0)
                {
                    Console.WriteLine(i);
                    toplam += i;
                }
            }
            Console.WriteLine("Asal sayıların toplamı = {0}",toplam);
        }
    }
}
