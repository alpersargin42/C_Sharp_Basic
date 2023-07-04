using System;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] sehir = { "Ankara", "Karaman", "Konya" };
            int[] plaka = new int[sehir.Length];
            for (int i = 0; i < sehir.Length; i++)
            {
                Console.WriteLine(sehir[i] + " " + "Plakasını Giriniz.");
                plaka[i] = Convert.ToInt32(Console.ReadLine());
                result(sehir[i],plaka[i]);
                if (result(sehir[i], plaka[i])== false)
                {
                    Console.WriteLine("Lütfen Plakayı Doğru Giriniz.");
                }
                else 
                {
                    for (int j = 0; j < sehir.Length; j++)
                    {
                        if (result(sehir[j], plaka[j])==false)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(sehir[j] + " " + plaka[j]);
                        }
                    }
                }
            }  
        }
        private static bool result(string sehir,int plaka)
        {
            if (sehir == "Ankara" && plaka != 06)
            {
                return false;
            }
            else if (sehir == "Karaman" && plaka != 70)
            {
                return false;
            }
            else if (sehir == "Konya" && plaka != 42)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
