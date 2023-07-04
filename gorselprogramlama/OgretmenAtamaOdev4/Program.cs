using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgretmenAtamaOdev4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogretmen_listesi = { "Ali ", "Ahmet ", "Mehmet", "Hasan ", "Hüseyin", "Cengiz", "Ayşe", "Ayça", "Hatice", "Doğan", };

            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Persembe", "Cuma" };

            string[] ogretmen = new string[10];

            int k = 0;
           
            int sayac = 0;

            int[] sayilar = new int[10];

            Random rastgele = new Random();
            do
            {
                int secilen1 = rastgele.Next(10);
                int secilen2 = rastgele.Next(10);
                if (secilen1 !=secilen2)
                {
                    sayilar[k] = secilen1;
                    k++;
                    sayilar[k] = secilen2;
                    k++;
                    sayac++;
                }
            } while (sayac==9);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
