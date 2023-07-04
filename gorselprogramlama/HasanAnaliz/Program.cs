using System;

namespace HasanAnaliz
{
    class Program
    {
            public static double Xi(double a, double b)
            {
                return Math.Pow(Math.E,b);
            }
            public static double Yi(double a, double b)
            {
                return (Math.Sqrt(a*a/2));
            }

            public static double F(double a, double b)
            {
            return Math.Pow(Math.E, b);
        }
            public static double G(double a, double b)
            {
            return (Math.Sqrt(a * a / 2));
        }
            public static double Gy(double a, double b)
            {
                return 0;
            }
            public static double Gx(double a, double b)
            {
                return (a/(2*Math.Sqrt(1/(2*a*a))));
            }
            public static double Fy(double a, double b)
            {
                return (Math.Pow(Math.E,b));
            }
            public static double Fx(double a, double b)
            {
                return 0;
            }
            static void Main(string[] args)
            {
                double a, b;
                double x, y;
                a = 0.9;
                b = 1.6;

                while (true)
                {
                    x = a - (F(a, b) * Gy(a, b) - Fy(a, b) * G(a, b)) / (Fx(a, b) * Gy(a, b) - Fy(a, b) * Gy(a, b));
                    y = b - (Fx(a, b) * G(a, b) - F(a, b) * Gx(a, b)) / (Fx(a, b) * Gy(a, b) - Fy(a, b) * Gy(a, b));
                    Console.WriteLine("X = {0}\nY = {1}", x, y);
                    Console.ReadLine();
                    a = x;
                    b = y;
                }


                //Console.WriteLine("Xi = {0}", Xi(0,-0.666));
                //Console.WriteLine("Yi = {0}", Yi(0,-0.666));
                //Console.WriteLine(Math.Log(Math.E));


            }
        }
}
