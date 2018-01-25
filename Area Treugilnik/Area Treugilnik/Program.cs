using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Treugilnik
{
    class Program
    {
        static void Main(string[] args)
        {
           double q , a = 5, b = 7,c,s;
            q = (double)Math.Pow(a, 2) + (double)Math.Pow(b, 2);
            Console.WriteLine(q);
            c = Math.Sqrt(q);
            Console.WriteLine(c);
            s = (a * b) / 2;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
