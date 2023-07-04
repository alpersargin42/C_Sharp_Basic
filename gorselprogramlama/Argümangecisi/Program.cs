using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argümangecisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            kuphesapla(ref x);

        }
        static void kuphesapla(ref int sayi)
        {
            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);
        }
    }
}
