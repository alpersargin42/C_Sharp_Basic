using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string soyadi = "ay";
            Console.WriteLine(soyadi);
            string a = Console.ReadLine();
            int sayi = Convert.ToInt32(a);
            Console.WriteLine(sayi);
            
            

            int dogum=10, tarihi=12;
            Console.WriteLine("Doğum yeri tarihi " +dogum + " " +tarihi);

            int vize;
            double ortalamam, final;
            final = 70;
            vize = 91;
            ortalamam =(vize + final) / 2;
            
            Console.WriteLine(ortalamam);
            ortalamam = vize/2 + final/2;
            Console.WriteLine(ortalamam);
            //Console.WriteLine("d+b {0} \nb-d{1} \nd*b {2}",d+b,b-d,d*b);
            Console.WriteLine("Vize={0} \t Final={1} \t Oralama={2}", vize, final, Convert.ToDouble((vize) + final)/ 2);

            Console.WriteLine("Notunuzu giriniz = ");
            int not = int.Parse(Console.ReadLine());

            
            Console.Read();
        }
    }
}
