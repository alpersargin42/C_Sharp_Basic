using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kaç haneli şifre girmek istiyorsunuz");
                int a = int.Parse(Console.ReadLine());
                if (a <= 10)
                {
                    string sifre = "";
                    int dizim;
                    Random ata = new Random();
                    for (int i = 0; i < a; i++)
                    {
                        dizim = ata.Next(255);
                        sifre += Convert.ToChar(dizim);
                    }
                    Console.WriteLine(sifre);
                    break;
                }
                else
                {
                    Console.WriteLine("10 haneden fazla girmeyiniz");
                }
            }
        }
    }
}
