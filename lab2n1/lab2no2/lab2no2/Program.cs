using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2no2
{
    class Program
    {
        static void Main(string[] args)
        {
            int test(int e)
            {
                int cnt = 0;
                for (int i = 1; i <= e; ++i)
                    if (e % i == 0)
                        cnt++;
                return cnt;
            }
            int minn = 10000000;
            string line = File.ReadAllText(@"C:\Users\asus\Desktop\Новая папка\lab2n1\lab2no2\lab2no2\t.txt");
            string[] a = line.Split(' ');
            foreach (string s in a)
            {
                int l = int.Parse(s);
                if ((test(l) == 2) && (minn > l))
                    minn = l;
            }
            StreamWriter sr = new StreamWriter(@"C:\Users\asus\Desktop\Новая папка\lab2n1\lab2no2\lab2no2\a.txt");
            sr.WriteLine(minn);
            sr.Close();
            Console.ReadKey();
        }
    }
    
}
