using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        class rectangle
        {
            double a, b, c, d;

            public rectangle(double a, double b)
            {
                this.a = a;
                this.b = b;
                findarea();
                findperimetre();

            }
            public void findarea()
            {
                this.c = a * b;
            }
            public void findperimetre()
            {
                this.d = 2 * (a + b);
            }
            public override string ToString()
            {
                return "Area===" +  c  + "\nPerimetre===" + d;
            }



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Width?&&&&");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Height?&&&&");
            double b = double.Parse(Console.ReadLine());
            rectangle s = new rectangle(a, b);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}


