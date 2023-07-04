using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekMagazaIndirim
{
    class Program
    {
        static void Main(string[] args)
        {
            double ceket = 250, pantolon = 150, gomlek = 100, ayakkabi = 200, canta = 225, kemer = 100;
            bool ceketkontrol=false, pantolonkontrol= false, gomlekkontrol= false, ayakkontrol= false, cantakontrol= false, kemerkontrol= false;
            double toplam2=0;
            Console.WriteLine("Ceket alacak mısın ? E/H");
            ceketkontrol = Alma(ceketkontrol);
            Console.WriteLine("Pantolon alacak mısın ? E/H");
            pantolonkontrol = Alma(pantolonkontrol);
            Console.WriteLine("Gomlek alacak mısın ? E/H");
            gomlekkontrol = Alma(gomlekkontrol);
            Console.WriteLine("Ayakkabı alacak mısın ? E/H");
            ayakkontrol = Alma(ayakkontrol);
            Console.WriteLine("Canta alacak mısın ? E/H");
            cantakontrol = Alma(cantakontrol);
            Console.WriteLine("Kemer alacak mısın ? E/H");
            kemerkontrol = Alma(kemerkontrol);
            Console.WriteLine("Kaç adet ürün alacaksınız ?");
            int adet = int.Parse(Console.ReadLine());
            if (adet==1)
            {
                if (ceketkontrol==true)
                {
                    Console.WriteLine("Çeketin normal fiyatı {0} İndirimli fiyatı {1}",ceket,ceket -(ceket * 0.05));
                }
                else if (pantolonkontrol == true)
                    Console.WriteLine("Pantolon normal fiyatı {0} İndirimli fiyatı {1}", pantolon, pantolon - (pantolon * 0.05));
                else if (ayakkontrol ==true)
                {
                    Console.WriteLine("Ayakkabı normal fiyatı {0} İndirimli fiyatı {1}", ayakkabi, ayakkabi - (ayakkabi * 0.05));
                }
                else if (cantakontrol ==true)
                {
                    Console.WriteLine("Canta  normal fiyatı {0} İndirimli fiyatı {1}", canta, canta - (canta * 0.05));
                }
            }
            else if (adet >= 3 && adet < 5)
            {
                if (ceketkontrol == true && pantolonkontrol == true && ayakkontrol == true)
                {
                    double indirimyirmi = ceket + pantolon + ayakkabi;
                    Console.WriteLine("Toplam tutar {0} indirimli hali {1}", indirimyirmi, indirimyirmi * 0.80);
                }
                else if (cantakontrol == true && kemerkontrol == true && ayakkontrol == true)
                {
                    double indirimyirmi = canta + kemer + ayakkabi;
                    Console.WriteLine("Toplam tutar {0} indirimli hali {1}", indirimyirmi, indirimyirmi * 0.80);
                }
            }
            else if (ceketkontrol==true && pantolonkontrol==true )
            {
                Console.WriteLine("Çeketin normal fiyatı {0} İndirimli fiyatı {1}", ceket, (ceket - (ceket * 0.20)));
                Console.WriteLine("Pantolon normal fiyatı {0} İndirimli fiyatı {1}", pantolon, pantolon - (pantolon * 0.20));
                Console.WriteLine("Toplam fiyat {0}", (ceket - (ceket * 0.20)) + pantolon - (pantolon * 0.20));
            }
            else if (ayakkontrol == true && kemerkontrol==true)
            {
                Console.WriteLine("Ayakkabı normal fiyatı {0} İndirimli fiyatı", ayakkabi, ayakkabi - (ayakkabi * 0.20));
                Console.WriteLine("Pantolon normal fiyatı {0} İndirimli fiyatı", pantolon, pantolon - (pantolon * 0.20));
            }
            else
            {
                double indirimotuz = ceket + pantolon + gomlek + ayakkabi + canta + kemer;
                Console.WriteLine("Toplam tutar {0} indirimli hali {1}", indirimotuz, indirimotuz * 0.70);
            }
        }

        private static bool Alma(bool urunkontrol)
        {
            char secim = Char.Parse(Console.ReadLine());
            if (secim == 'E')
            {
                urunkontrol = true;

            }

            return urunkontrol;
        }
    }
}
