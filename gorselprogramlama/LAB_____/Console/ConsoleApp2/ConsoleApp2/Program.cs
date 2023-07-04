using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, numara;
            Console.WriteLine("Ad:");
            ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            soyad = Console.ReadLine();
            Console.WriteLine("Numara:");
            numara = Console.ReadLine();

            double vize, final, ort;
            Console.WriteLine("Vize Notunuzu Giriniz:");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giriniz:");
            final = Convert.ToDouble(Console.ReadLine());
            if ((vize < 0 || vize > 100) || (final < 0 || final > 100))
            {
                Console.WriteLine("Lütfen Geçerli Not giriniz.");
            }
            ort = (vize * .4) + (final * .6);
            Console.WriteLine("Ortalama:{0}", ort);

            if (ort <= 100 && ort >= 85)
            {
                Console.WriteLine("A");
            }
            else if (ort <= 84 && ort >= 65)
            {
                Console.WriteLine("B");
            }
            else if (ort <= 64 && ort >= 40)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("KALDINIZ.");
            }


        }
    }
}
