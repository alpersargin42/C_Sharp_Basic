using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Güne göre random nöbet atama
             * Matematik fonksiyonları
             * Yılın bugünü
             * fonksiyonla void ve return
             *
             */
            
                string[] ogr1 = { "Alper", "Aysegul", "Abdurrahim", "Fadim", "Busra", "Veli" };
                Random rand = new Random();
                string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
                int a;
                foreach (var item in gunler)
                {
                    a = rand.Next(ogr1.Length);
                    Console.WriteLine(item + " " + ogr1[a]);
                    ogr1 = ogr1.Where(x => x != ogr1[a]).ToArray();
                    a = rand.Next(ogr1.Length);
                    Console.WriteLine(item+" "+ogr1[a]);
                    Console.WriteLine("==================================");
                }



        }
    }
}
