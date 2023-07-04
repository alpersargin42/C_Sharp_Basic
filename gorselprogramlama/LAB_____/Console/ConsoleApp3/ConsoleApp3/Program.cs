using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayıyı ters çevirme
            //plaka yazıdr
            //matris çarpımı


            /*
             *
             * SAYIYI tersten yazdırma
             */

            int sayi =0 ;
            Console.WriteLine("Üç basamaklı sayı giriniz.");
            sayi = Convert.ToInt32(Console.ReadLine());
            int yuzler = (sayi / 100);
            int onlar = (sayi - (yuzler * 100)) / 10;
            int birler = (sayi - (yuzler * 100) - (onlar * 10)) / 1;

            Console.WriteLine("Tersi:{0}{1}{2}",birler,onlar,yuzler);

        }
    }
}
