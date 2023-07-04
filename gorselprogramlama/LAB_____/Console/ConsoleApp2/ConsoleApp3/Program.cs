using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ceket pan ayak -- ceket250 pan 150 gom 100 ayak 200 canta 225 kemer 100--çeşitlerden en fazla 1 alıyor 120 ve üzeri yüzde 5 pan ve ceket veya ayak ve
            //kemer veya en az 3 ürün yüzde 20 5 ve üzerine yüzde 30

            int p_price = 150;
            int cek_price = 250;
            int g_price = 100;
            int a_price = 200;
            int can_price = 200;
            int k_price = 200;
            int sayac_pan = 0;
            int sayac_cek = 0;
            int sayac_g = 0;
            int sayac_a = 0;
            int sayac_can = 0;
            int sayac_k = 0;
            int total_sayac = 0;
            int total_price = 0;
            string a;
            Console.WriteLine("Ceket Almak İster misiniz? E/H");
            a = Console.ReadLine();
            if (a == "E" || a == "e")
            {
                total_price = total_price + cek_price;
                sayac_cek++;
                total_sayac++;
            }
            Console.WriteLine("Pantolon Almak İster misiniz? E/H");
            a = Console.ReadLine();
            if (a == "E" || a == "e")
            {
                total_price = total_price + p_price;
                sayac_pan++;
                total_sayac++;
            }
            Console.WriteLine("Gömlek Almak İster misiniz? E/H");
            a = Console.ReadLine();
            if (a == "E" || a == "e")
            {
                total_price = total_price + g_price;
                sayac_g++;
                total_sayac++;
            }
            Console.WriteLine("Ayakkabı Almak İster misiniz? E/H");
            a = Console.ReadLine();
            if (a == "E" || a == "e")
            {
                total_price = total_price + a_price;
                sayac_a++;
                total_sayac++;
            }
            Console.WriteLine("Çanta Almak İster misiniz? E/H");
            a = Console.ReadLine();
            if (a == "E" || a == "e")
            {
                total_price = total_price + can_price;
                sayac_can++;
                total_sayac++;
            }
            Console.WriteLine("Kemer Almak İster misiniz? E/H");
            a = Console.ReadLine();
            if (a == "E" || a == "e")
            {
                total_price = total_price + k_price;
                sayac_k++;
                total_sayac++;
            }

            if (sayac_pan + sayac_cek == 2 && sayac_a + sayac_can + sayac_g + sayac_k == 0)
            {
                total_price = (total_price) - ((total_price * 20) / 100);
                Console.WriteLine("Ödeyeceğiniz Tutar={0}", total_price);
                Console.WriteLine("Yüzde 20 İndirim Sağlanmıştır.");
            }
            else if (sayac_a + sayac_k == 2 && sayac_a + sayac_can + sayac_g + sayac_k == 0)
            {
                total_price = (total_price) - ((total_price * 20) / 100);
                Console.WriteLine("Ödeyeceğiniz Tutar={0}", total_price);
                Console.WriteLine("Yüzde 20 İndirim Sağlanmıştır.");
            }
            else if (total_sayac >= 5)
            {
                total_price = (total_price) - ((total_price * 30) / 100);
                Console.WriteLine("Ödeyeceğiniz Tutar={0}", total_price);
                Console.WriteLine("Yüzde 30 İndirim Sağlanmıştır.");
            }
            else if (total_sayac >= 3 && total_sayac < 5)
            {
                total_price = (total_price) - ((total_price * 20) / 100);
                Console.WriteLine("Ödeyeceğiniz Tutar={0}", total_price);
                Console.WriteLine("Yüzde 20 İndirim Sağlanmıştır.");
            }

            else if (total_price >= 120)
            {
                total_price = (total_price) - ((total_price * 5) / 100);
                Console.WriteLine("Ödeyeceğiniz Tutar={0}", total_price);
                Console.WriteLine("Yüzde 5 İndirim Sağlanmıştır.");

            }
            else
            {
                Console.WriteLine("İndirim Uygulanmamıştır.");
            }

        }
    }
}
