using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel4.hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ikiboyutludizi = new int[,] { { 1, 2 }, { 3, 4 }, { 1, 2 }, { 3, 4 } };  //iki boyutludizi tanımlama 
            int[,,] ucboyutludizi = new int[,,] { { { 1, 2, 3 }, { 3, 4, 5 }, { 1, 2, 6 }, { 3, 4, 3 } } };
            string[,,] ucboyutlu_string = new string[,,] { { { "Ahmet", "Mehmet", "Cengiz" }, { "Ahmet", "Mehmet", "Cengiz" }, { "Ahmet", "Mehmet", "Cengiz" }, { "Ahmet", "Mehmet", "Cengiz" } } };
            int[,,] ucboyutludizi_int = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine(ucboyutludizi_int[1, 1, 1]);

            int[,] A = { { 4, 0, 1 }, { -1, 2, -1 } };
            int[,] B = { { 2, 3 }, { 1, 2 }, { 2, -1 } };

            //for (int i =0 ; i <3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        A[i][j] * B[i][j];
            //    }

            //}
            Random rand = new Random();
            double d = rand.NextDouble();
            Console.WriteLine(" " + d);

            string[] ogretmen_listesi = { "Ali ", "Ahmet ", "Mehmet", "Hasan ", "Hüseyin", "Cengiz", "Ayşe", "Ayça", "Hatice", "Doğan", };

            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Persembe", "Cuma" };

            string[] ogretmenler = new string[9];

            string[] gun = new string[5];

            Random rastgele = new Random();

            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next(0, 11);
                ogretmenler[i] = ogretmen_listesi[a];

            }
           

              
           
        }
    }
}
