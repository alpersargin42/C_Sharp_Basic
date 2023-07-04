using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaIndirimi3.hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            double ceket = 250, pantolon = 150, gomlek = 100, ayakkabı = 200, canta = 225, kemer = 100;<
            int sayac = 0; //ürün saydır
            double toplam = 0;
            double toplam2 =0;
            double toplam3 = 0;
            double toplami=0, toplamim=0;
            char secim;
            char[] secimdizi = new char[40];
            Console.WriteLine("Ceket aldın mı E/H");
            secim= Char.Parse(Console.ReadLine());
            if (secim =='E')
            {
                sayac++;
                toplam2 += ceket;
                toplam += ceket;
            }
            secimdizi[0] = secim;
            Console.WriteLine("Pantolon aldın mı E/H");
            secim = Char.Parse(Console.ReadLine());
            if (secim == 'E')
            {
                sayac++;
                toplam2 += pantolon;
                toplam += pantolon;
            }
            secimdizi[1] = secim;
            Console.WriteLine("Gömlek aldın mı E/H");
            secim = Char.Parse(Console.ReadLine());
            if (secim == 'E')
            {
                sayac++;
                toplam2 += gomlek;
                toplam += gomlek;
            }
            secimdizi[2] = secim;
            Console.WriteLine("Ayakkabı aldın mı E/H");
            secim = Char.Parse(Console.ReadLine());
            if (secim == 'E')
            {
                sayac++;
                toplam3 += ayakkabı;
                toplam += ayakkabı;
            }
            secimdizi[3] = secim;
            Console.WriteLine("Çanta aldın mı E/H");
            secim = Char.Parse(Console.ReadLine());
            if (secim == 'E')
            {
                sayac++;
                toplam3 += ayakkabı;
                toplam += ayakkabı;
            }
            secimdizi[4] = secim;
            Console.WriteLine("Kemer aldın mı E/H");
            secim = Char.Parse(Console.ReadLine());
            if (secim == 'E')
            {
                sayac++;
                toplam3 += ayakkabı;
            }
            secimdizi[5] = secim;


            if (sayac > 5)
            {
                toplam = toplam * 0.30;
                Console.WriteLine(toplam);
            }
            else if ((secimdizi[1] == 'E' && secimdizi[0] == 'E') || (secimdizi[3]=='E' && secimdizi[5] =='E') || sayac<5) 
            {
                if ((secimdizi[1] == 'E' && secimdizi[0] == 'E'))
                {
                    toplami += (pantolon - (pantolon * 0.20) + (ceket - (ceket * 0.20)));
                }
                else if (secimdizi[3] == 'E' && secimdizi[5] == 'E')
                {
                    toplami += (ayakkabı - (ayakkabı * 0.20) + (kemer - (kemer * 0.20)));
                }
                else
                {
                    if ((secimdizi[0] == 'E' && secimdizi[1] =='E' && secimdizi [2] =='E') || (secimdizi[3] == 'E' && secimdizi[4] == 'E' && secimdizi[5] == 'E'))
                    {
                        if (secimdizi[0] == 'E' && secimdizi[1] == 'E' && secimdizi[2] == 'E')
                        {
                            toplam2 += toplam2 * 0.20;
                            Console.WriteLine(toplam2);
                        }
                        else if (secimdizi[3] == 'E' && secimdizi[4] == 'E' && secimdizi[5] == 'E')
                        {
                            toplam3 += toplam3 * 0.20;
                            Console.WriteLine(toplam3);
                        }
                    }
                }
            }
            else if (secimdizi[0] == 'E' || secimdizi[1] == 'E' || secimdizi[3] == 'E' || secimdizi[4] == 'E')
            {
                if (secimdizi[0] == 'E')
                {
                    toplamim += ceket - (ceket * 0.05);
                }
                else if (secimdizi[1] == 'E')
                {
                    toplamim += pantolon - (pantolon * 0.05);
                }
                else if (secimdizi[3] == 'E')
                {
                    toplamim += ayakkabı - (ayakkabı * 0.05);
                }
                else if (secimdizi[4] == 'E')
                {
                    toplamim += canta - (canta * 0.05);
                }
                else if (secimdizi[5] == 'E')
                {
                    toplamim += kemer - (kemer * 0.05);
                }
            }
        }

       
    }
}
