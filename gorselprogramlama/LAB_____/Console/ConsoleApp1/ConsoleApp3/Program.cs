using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string gun = Convert.ToString(DateTime.Now.Day);
            string ay = Convert.ToString(DateTime.Now.Month);
            string yil = Convert.ToString(DateTime.Now.Year);
            string saat = Convert.ToString(DateTime.Now.Hour);
            string dakika = Convert.ToString(DateTime.Now.Minute);
            string saniye = Convert.ToString(DateTime.Now.Second);
            DateTime gunlerden=DateTime.Now;
            Console.WriteLine("Gün: {0}  Ay: {1}  Yıl:{2}  Saat:{3}  Dakika:{4}  Saniye:{5}", gun, ay, yil, saat,
                dakika, saniye);
            int isParsable1 = Int32.Parse(ay);
            Console.Write("AY:");
            string m = "";
            switch (isParsable1)
            {
                case 1:
                    Console.WriteLine("OCAK");
                    m = "OCAK";
                    break;
                case 2:
                    Console.WriteLine("ŞUBAT");
                    m = "ŞUBAT";
                    break;
                case 3:
                    Console.WriteLine("MART");
                    m = "MART";
                    break;
                case 4:
                    Console.WriteLine("NİSAN");
                    m = "NİSAN";
                    break;
                case 5:
                    Console.WriteLine("MAYIS");
                    m = "MAYIS";
                    break;
                case 6:
                    Console.WriteLine("HAZİRAN");
                    m = "HAZİRAN";
                    break;
                case 7:
                    Console.WriteLine("TEMMUZ");
                    m = "TEMMUZ";
                    break;
                case 8:
                    Console.WriteLine("AĞUSTOS");
                    m = "AĞUSTOS";
                    break;
                case 9:
                    Console.WriteLine("EYLÜL");
                    m = "EYLÜL";
                    break;
                case 10:
                    Console.WriteLine("EKİM");
                    m = "EKİM";
                    break;
                case 11:
                    Console.WriteLine("KASIM");
                    m = "KASIM";
                    break;
                case 12:
                    Console.WriteLine("ARALIK");
                    m = "ARALIK";
                    break;
            }

            Console.Write("Bugün Günlerden:");
            string isParsable2 = Convert.ToString(gunlerden.DayOfWeek);
            string d = "";
            switch (isParsable2)
            {
                case "Monday":
                    Console.WriteLine("Pazartesi");
                    d = " Pazartesi";
                    break;
                case "Tuesday":
                    Console.WriteLine("Salı");
                    d = " Salı";
                    break;
                case "Wednesday":
                    Console.WriteLine("Çarşamba");
                    d = " Çarşamba";
                    break;
                case "Thursday":
                    Console.WriteLine("Perşembe");
                    d = " Perşembe";
                    break;
                case "Friday":
                    Console.WriteLine("Cuma");
                    d = " Cuma";
                    break;
                case "Saturday":
                    Console.WriteLine("Cumartesi");
                    d = " Cumartesi";
                    break;
                case "Sunday":
                    Console.WriteLine("Pazar");
                    d = " Pazar";
                    break;
            }

            Console.WriteLine(gun+" "+m+""+d);
            
        }
    }
}
