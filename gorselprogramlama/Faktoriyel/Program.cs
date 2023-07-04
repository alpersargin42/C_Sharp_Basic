using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            faktoriyel(5);

        }
        static void faktoriyel(int a)
        {
            int say=1;
            for (int i = a; i>0; i--)
            {
                say = say * i;
            }
            Console.WriteLine(say);
        }
    }
}
