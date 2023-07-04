using System;

namespace ConsoleApp5
{
    class Urun
    {
        public int fiyat { get; set; }
        public string tur { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string uretim_yili { get; set; }
        public string barkod_kodu { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urn1 = new Urun();
            urn1.fiyat = 5;
            urn1.tur = "Ciklet";
            urn1.marka = "First";
            urn1.model = "Mentollü";
            urn1.uretim_yili = "1990";
            urn1.barkod_kodu = "1ADbX";
            Urun urn2 = new Urun();
            urn2.fiyat = 500;
            urn2.tur = "Ayakkabı";
            urn2.marka = "Nike";
            urn2.model = "Jordan";
            urn2.uretim_yili = "2022";
            urn2.barkod_kodu = "1ADSV";
            yazdir(urn1);
            yazdir(urn2);
            Urun urn3 = new Urun();
            urn3.barkod_kodu = Convert.ToString(Console.ReadLine());
            barkod(urn3);
            //barkod(urn2);

        }

        private static void yazdir(Urun urn)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Urun fiyati={0}",urn.fiyat);
            Console.WriteLine("Urun tur={0}",urn.tur);
            Console.WriteLine("Urun markasi={0}",urn.marka);
            Console.WriteLine("Urun model={0}",urn.model);
            Console.WriteLine("Urun uretim yili={0}",urn.uretim_yili);
            Console.WriteLine("Urun barkod kodu={0}",urn.barkod_kodu);
        }
        private static void barkod(Urun urn1)
        {
            if (urn1.barkod_kodu== "1ADbX")
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Urun fiyati={0}", urn1.fiyat);
                Console.WriteLine("Urun tur={0}", urn1.tur);
                Console.WriteLine("Urun markasi={0}", urn1.marka);
                Console.WriteLine("Urun model={0}", urn1.model);
                Console.WriteLine("Urun uretim yili={0}", urn1.uretim_yili);
                Console.WriteLine("Urun barkod kodu={0}", urn1.barkod_kodu);
            }
            else if(urn1.barkod_kodu== "1ADSV")
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Urun fiyati={0}", urn1.fiyat);
                Console.WriteLine("Urun tur={0}", urn1.tur);
                Console.WriteLine("Urun markasi={0}", urn1.marka);
                Console.WriteLine("Urun model={0}", urn1.model);
                Console.WriteLine("Urun uretim yili={0}", urn1.uretim_yili);
                Console.WriteLine("Urun barkod kodu={0}", urn1.barkod_kodu);
            }
            
        }
    }
}
