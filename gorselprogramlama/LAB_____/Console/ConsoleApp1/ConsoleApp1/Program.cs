using System;
/* 4.HAFTA
 * 1 den 100 e asal sayı listeleme
 * fibonacci sayı dizisini yazdır 0 a basınca dur 1 yapınca devam et
 * Switch case yapısıyla gün ay yıl ve günleri türkçeye çevirme
 */
namespace ConsoleApp1
{
    class Program
    {
        //FİBONACCİ SAYI DİZİSİ
        static void Main(string[] args)
        {
            int ilksayi = 1;
            int ikincisayi = 1;
            int adet=0;
            Console.Write("Kaç Tane Fibonocci Sayısı Görmek İstiyorsunuz = ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.Write(ilksayi + " " + ikincisayi + " ");
            for (int i = 3; i <= adet; i++)
            {
                int sonuc = ilksayi + ikincisayi;
                Console.Write(sonuc + " ");
                ilksayi = ikincisayi;
                ikincisayi = sonuc;
            }
            Console.ReadLine();
        }
    }
}
