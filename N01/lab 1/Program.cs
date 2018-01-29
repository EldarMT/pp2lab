using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string li;
                li = Console.ReadLine();
                args = li.Split(' ');
                foreach (string s in args)// для всех strings в массива аргс выполняется следующее
                {
                    int a = int.Parse(s); // переводит string на int

                    int sum = 0; // счетчик делители
                    if (a == 1)
                    {
                        sum = 1;// потому что 1 не простое число
                    }
                    for (int i = 2; i * i <= a; ++i)
                        if (a % i == 0)// если делит то 
                        {
                            sum = sum + 1;// увеличиваем количестов делители на l
                        }
                    if (sum == 0)
                        Console.WriteLine(a);   // если нет делители в интервале от 2 до sqrt(n) то выводим это число
                }
                Console.ReadKey();    // чтобы компилятор не отключалось 
            }
        }
    }
}
