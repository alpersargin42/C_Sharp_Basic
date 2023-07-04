using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsim giriniz");
            string ad = Console.ReadLine();
            isimsoyle(ad);
        }

        static void isimsoyle(string ad)
        {
            Console.WriteLine(ad);
        }


    }
}
