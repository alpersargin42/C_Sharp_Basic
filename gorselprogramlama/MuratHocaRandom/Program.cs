using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratHocaRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            string[] sehirler = { "Ankara", "Bursa", "İzmir", "Aydın", "İstanbul", "Trabzon", "Ankara", "Adıyaman", "Konya", "Sivas"};

            int a;
            a = rastgele.Next(0, sehirler.Length);

            Console.WriteLine(sehirler[a]);
        }
    }
}
