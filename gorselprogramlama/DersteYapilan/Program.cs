using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersteYapilan
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double sum = 0;
            Console.WriteLine("almak istediğiniz ürün adedini giriniz:\n");
            num = Convert.ToInt32(Console.ReadLine());


            string[] arr = new string[num];

            Console.WriteLine("1-ceket 250₺\n2-pantolon 150₺\n3-gomlek 100₺\n4-ayakkabı 200₺\n5-canta 225₺\n6-kemer 100₺\n" +
                "almak istediğiniz ürünlerin isimlerini giriniz:\n");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToString(Console.ReadLine());

            }


            for (int i = 0; i < num; i++)
            {

                switch (arr[i])
                {
                    case "ceket":
                        sum += 250;
                        break;

                    case "pantolon":
                        sum += 150;
                        break;

                    case "gomlek":
                        sum += 100;
                        break;

                    case "ayakkabı":
                        sum += 200;
                        break;

                    case "canta":
                        sum += 225;
                        break;

                    case "kemer":
                        sum += 100;
                        break;

                }

            }

            if (num == 1 && sum >= 120)
            {
                Console.WriteLine("kazandığınız indirim %5\n" + "toplam ürün tutarı:" + (sum - (sum * 0.05)));
            }

            else if ((num == 2 && sum == 400) || (num == 2 && sum == 300) || (num == 3))
            {
                Console.WriteLine("kazandığınız indirim %20\n" + "toplam ürün tutarı:" + (sum - (sum * 0.2)));
            }

            else if (num >= 5)
            {
                Console.WriteLine("kazandığınız indirim %30\n" + "toplam ürün tutarı:" + (sum - (sum * 0.3)));
            }

            else
            {
                Console.WriteLine("kazandığınız indirim %0\n" + "toplam ürün tutarı:" + sum);

            }


            Console.Read();


        }
    }
    }
