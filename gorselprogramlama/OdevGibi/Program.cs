using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevGibi
{
    class Program
    {
        static void Main(string[] args)
        {
            string vize, final, proje, dersadi;
            double devamsizlik;
            double ortalama;
            Console.WriteLine("Ders Adını giriniz");
            dersadi = Console.ReadLine();
            Console.WriteLine("Vize notunuzu giriniz");
            vize = Console.ReadLine();
            Console.WriteLine("Final notunuzu giriniz");
            final = Console.ReadLine();
            Console.WriteLine("Proje notunuzu giriniz");
            proje = Console.ReadLine();
            Console.WriteLine("Devamsızlık bilgisi giriniz");
            devamsizlik = double.Parse(Console.ReadLine());
            double vizem, finali, projem;
            DersNotuHesapla(vize,dersadi,final, proje, devamsizlik, out ortalama, out vizem, out finali, out projem);
        }

        private static void DersNotuHesapla(string vize,string dersadi,string final, string proje, double devamsizlik, out double ortalama, out double vizem, out double finali, out double projem)
        {
            vizem = Double.Parse(vize) * 0.25;
            finali = Double.Parse(final) * 0.45;
            projem = Double.Parse(proje) * 0.30;
            ortalama = vizem + finali + projem;
            if (devamsizlik < 10 && ortalama > 50)
            {
                if (dersadi=="görsel programlama")
                {
                    ortalama += 20; 
                    
                    if (ortalama>100)
                    {

                        Console.WriteLine("Öğrencinin geçtiği not ortalaması = {0} " ,100);
                    }
                    else
                    {
                        Console.WriteLine("Öğrencinin geçtiği not ortalaması = {0}", ortalama);

                    }
                    

                }
                else
                {
                    Console.WriteLine("Öğrencinin geçtiği not ortalaması = {0}", ortalama);
                }
            }
            else
            {
                Console.WriteLine("Öğrenci kalır");
            }
            Console.ReadLine();
        }
        
    }
    
}
