using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            double islem=1;
            for (double i = a; i >1 ; i--)
            {
                islem += i / faktoriyel(i);
            }
            Console.WriteLine(islem);
        }
        static double faktoriyel(double x)
        {
            double toplam=1;
            for (double i = x; i >1; i--)
            {
                toplam *= i;
            }
            return toplam;
        }
    }
}
