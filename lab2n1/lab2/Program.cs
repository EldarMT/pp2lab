using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineb = File.ReadAllText(@"C:\Users\asus\Desktop\Новая папка\lab2n1\lab2\t.txt");



            string[] line = lineb.Split(' ');

            int maxxi = -10000000;
            int minni = 10000000;
            foreach (string e in line)
            {
                maxxi = Math.Max(maxxi, int.Parse(e));
                minni = Math.Min(minni, int.Parse(e));

            }
            Console.WriteLine("Minimum number is ***** ");
            Console.WriteLine(minni);
            Console.WriteLine("Maximum number is ***** ");
            Console.WriteLine(maxxi);

            Console.ReadKey();
        }
    }
}
